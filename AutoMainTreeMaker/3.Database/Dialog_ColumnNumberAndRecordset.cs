using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoMainTreeMaker.ResltForSource;

namespace AutoMainTreeMaker.Database
{
    public partial class Dialog_ColumnNumberAndRecordset : Form
    {
        public static int DEFAULT_COL_NUMBER = -1;

        private Dictionary<string,bool> recordsetList;
        private CRichTextBoxInterface richInterface;
        private List<CRichTextbox> richs;
        private Tree tree;

        private Dialog_ResultForSource resultDlg;
        private Dialog_Database databaseDlg;

        private struct RecordSetStackInfo
        {
            public string rsName;
            public int beginConNumber;
            public List<int> nodeSeqList;
            public RecordSetStackInfo(string name, int beginColnum)
            {
                rsName = name;
                beginConNumber = beginColnum;
                nodeSeqList = new List<int>();
            }
        }

        public Dialog_ColumnNumberAndRecordset(Tree tree, string [] mainTree, Dialog_ResultForSource dlg)
        {
            InitializeComponent();
            recordsetList = new Dictionary<string, bool>();
            this.tree = tree;
            richMainTree.Lines = mainTree;

            richs = new List<CRichTextbox>();
            richs.Add(richMainTree);
            richs.Add(richColumnNumber);
            richs.Add(richRecordsetName);

            richInterface = new CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            comboMethod.SelectedIndex = 0;

            resultDlg = dlg;
        }

        public void Make()
        {
            switch(comboMethod.SelectedIndex)
            {
                case 0:
                    MinimalMode();
                    break;

                case 1:
                    RangeMode();
                    break;

                case 2:
                    ManualMode();
                    break;
                default:
                    ManualMode();
                    break;
            }
        }

        private void ManualMode()
        {
            List<TreeNode> orderedNode = tree.GetOrderedNodeAsNodeSequence();
            foreach (TreeNode node in orderedNode)
            {
                if (node.IsParent)
                {
                    continue;
                }
                else
                {

                    string colnum = richColumnNumber.Lines[node.NodeSequence];
                    string rs = richRecordsetName.Lines[node.NodeSequence];
                    if (colnum != "")
                        node.ColumnNumber = Int32.Parse(colnum);
                    if (rs != "")
                    {
                        recordsetList.Add(rs, true);
                        node.RecordsetFileName = rs;
                    }
                }
            }
        }

        private void RangeMode()
        {

            List<TreeNode> orderedNode = tree.GetOrderedNodeAsNodeSequence();
            Stack<RecordSetStackInfo> rsStack = new Stack<RecordSetStackInfo>();
            foreach (TreeNode node in orderedNode)
            {

                if (node.IsParent)
                {
                    node.ColumnNumber = DEFAULT_COL_NUMBER;
                    continue;
                }
                else
                {
                    var thisRsName = richRecordsetName.Lines[node.NodeSequence];
                    if (rsStack.Count == 0 && thisRsName != "")
                    {
                        var newRs = new RecordSetStackInfo(thisRsName, Int32.Parse(richColumnNumber.Lines[node.NodeSequence]));
                        newRs.nodeSeqList.Add(node.NodeSequence);
                        rsStack.Push(newRs);
                        recordsetList.Add(thisRsName,true);
                    }
                    else if (rsStack.Count > 0 && rsStack.Peek().rsName == thisRsName)
                    {
                        var rsInfo = rsStack.Peek();
                        rsStack.Pop();
                        rsInfo.nodeSeqList.Add(node.NodeSequence);

                        int firstNumber = rsInfo.beginConNumber;
                        string rsName = rsInfo.rsName;
                        foreach (int nodeSeq in rsInfo.nodeSeqList)
                        {
                            orderedNode[nodeSeq].ColumnNumber = firstNumber++;
                            orderedNode[nodeSeq].RecordsetFileName = rsName;
                        }
                    }
                    //새로운 레코드셋
                    else if (rsStack.Count > 0 && thisRsName != "" && rsStack.Peek().rsName != thisRsName)
                    {
                        var newRs = new RecordSetStackInfo(thisRsName, Int32.Parse(richColumnNumber.Lines[node.NodeSequence]));
                        newRs.nodeSeqList.Add(node.NodeSequence);
                        rsStack.Push(newRs);
                        recordsetList.Add(thisRsName,true);
                    }
                    else
                        rsStack.Peek().nodeSeqList.Add(node.NodeSequence);
                }

            }
        }

        private void MinimalMode()
        {
            List<TreeNode> OrderedNode = tree.GetOrderedNodeAsNodeSequence();
            bool isBegin = false;
            int colNum = 3;
            string rsName = "";
            foreach (TreeNode node in OrderedNode)
            {
                if (node.IsParent)
                    continue;

                if (!isBegin && (richColumnNumber.Lines[node.NodeSequence] != "" || richRecordsetName.Lines[node.NodeSequence] != ""))
                {
                    colNum = Int32.Parse(richColumnNumber.Lines[node.NodeSequence]);
                    rsName = richRecordsetName.Lines[node.NodeSequence];
                    isBegin = true;
                }
                    
                node.ColumnNumber = colNum++;
                node.RecordsetFileName = rsName;
            }
        }

        public bool IsInvaliated()
        {
            List<TreeNode> OrderedNode = tree.GetOrderedNodeAsNodeSequence();
            bool isFillOfHeadNode = false;
            foreach (TreeNode node in OrderedNode)
            {
                if (node.IsParent && !richColumnNumber.Lines[node.NodeSequence].Equals(""))
                    return false;
                if (node.IsParent && !richRecordsetName.Lines[node.NodeSequence].Equals(""))
                    return false;
                if (!isFillOfHeadNode && node.IsHead && richColumnNumber.Lines[node.NodeSequence].Equals(""))
                    return false;
                else
                    isFillOfHeadNode = true;
            }
            return true;
        } 

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            richInterface.EqualLinesToMaximumLine();

            if(!IsInvaliated())
            {
                MessageBox.Show("부모노드에는 숫자나 레코드셋 파일명이 들어갈 수 없습니다. 혹은 첫 헤드노드엔 컬럼번호를 입력해야 합니다.");
                return;
            }

            
            Make();

            this.Hide();

            var rsList = new List<string>();
            foreach(var keys in recordsetList.Keys)
            {
                rsList.Add(keys);
            }

            if (databaseDlg == null)
                databaseDlg = new Dialog_Database(tree,rsList,this);

            databaseDlg.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            resultDlg.Show();
        }
    }
}
