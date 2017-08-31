using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoMainTreeMaker.ResltForSource;

namespace AutoMainTreeMaker.Database
{
    public partial class Dialog_ColumnNumberAndRecordset : Form
    {
        public static int DEFAULT_COL_NUMBER = -100;

        private CRichTextBoxInterface richInterface;
        private List<CRichTextbox> richs;
        private Tree tree;

        private Dialog_ResultForSource resultDlg;
        private Dialog_Database databaseDlg;

        public Dialog_ColumnNumberAndRecordset(Tree tree, string [] mainTree, Dialog_ResultForSource dlg)
        {
            InitializeComponent();

            this.tree = tree;
            richMainTree.Lines = mainTree;

            richs = new List<CRichTextbox>();
            richs.Add(richMainTree);
            richs.Add(richColumnNumber);
            richs.Add(richRecordsetName);

            richInterface = new CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            richColumnNumber.Lines = new string[tree.NodeCount];
            richRecordsetName.Lines = new string[tree.NodeCount];

            resultDlg = dlg;
        }

        public void Make()
        {
            List<TreeNode> OrderedNode = tree.GetOrderedNodeAsNodeSequence();
            int colNum = 3;
            string rsName = "";
            foreach (TreeNode node in OrderedNode)
            {
                if (node.IsParent)
                {
                    node.ColumnNumber = DEFAULT_COL_NUMBER;
                    continue;
                }
                if (richColumnNumber.Lines[node.NodeSequence] != "")
                    colNum = Int32.Parse(richColumnNumber.Lines[node.NodeSequence]);
                node.ColumnNumber = colNum++;

                if (richRecordsetName.Lines[node.NodeSequence] != "")
                    rsName = richRecordsetName.Lines[node.NodeSequence];
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
            if(!IsInvaliated())
            {
                MessageBox.Show("부모노드에는 숫자나 레코드셋 파일명이 들어갈 수 없습니다. 혹은 첫 헤드노드엔 컬럼번호를 입력해야 합니다.");
            }

            Make();

            this.Hide();
            if (databaseDlg == null)
                databaseDlg = new Dialog_Database(tree.GetOrderedNodeAsNodeSequence(),this);

            databaseDlg.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            resultDlg.ShowDialog();
        }
    }
}
