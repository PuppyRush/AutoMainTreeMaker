using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMainTreeMaker.MainTree;

namespace AutoMainTreeMaker
{
    class TreeMaker
    {

        private Dialog_MainTree wizard1;
        int gubunDepthGap;
        int gubunNodeGap;
        bool isSuccessedForMaking;

        Tree tree;

        string[] mainTree;

        public string[] MainTree
        {
            get { return mainTree; }
            set { mainTree = value; }
        }

        string[] enumValue;

        public string[] EnumValue
        {
            get { return enumValue; }
            set { enumValue = value; }
        }

        string[] variableName;

        public string[] VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }

        string[] columnName;

        public string[] ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        string[] gubunName;

        public string[] GubunName
        {
            get { return gubunName; }
            set { gubunName = value; }
        }

        private string[] enumName;
        public string[] EnumName
        {
            get
            {
                return enumName;
            }

            set
            {
                enumName = value;
            }
        }


        public Tree Tree
        {
            get
            {
                if (isSuccessedForMaking)
                    return tree;
                else
                    return null;
            }

            set
            {
                tree = value;
            }
        }

        public bool IsSuccessedForMaking
        {
            get
            {
                return isSuccessedForMaking;
            }

            set
            {
                isSuccessedForMaking = value;
            }
        }


        public TreeMaker(Dialog_MainTree wizard)
        {
            tree = new AutoMainTreeMaker.Tree();
            isSuccessedForMaking = false;
            gubunDepthGap = 10;
            gubunNodeGap = 1;
            this.wizard1 = wizard;
        }

        private bool IsValidData()
        {
            int NodeCount = mainTree.Length;

            char[] buf = new char[1];
            buf[0] = ' ';

            foreach (CRichTextbox r in wizard1.Richs)
            {
                if (r.Equals(wizard1.RichMainTree))
                    continue;
                r.Lines = RemoveEmptyLine(r.Lines);

                if (NodeCount != r.Lines.Length)
                {
                    r.Focus();
                    MessageBox.Show(r.Name + "목록이 트리와의 갯수가 불일치 합니다.");
                    return false;
                }
            }


            return true;
        }


        private string[] RemoveEmptyLine(string[] str)
        {
            List<string> newStr = new List<string>();

            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i].Length == 0)
                    count++;
                else
                    break;
            }

            for (int i = 0; i < str.Length - count; i++)
                newStr.Add(str[i]);

            return newStr.ToArray();
        }

        public void MakeNames(List<TreeNode> list, string gubunParent, string enumParent)
        {
            foreach (TreeNode node in list)
            {
                if (enumParent.Equals(""))
                {
                    node.EnumName = enumName[node.NodeSequence];
                    node.Gubun = gubunName[node.NodeSequence];
                }
                else
                {
                    node.EnumName = enumParent + "_" + enumName[node.NodeSequence];
                    node.Gubun = gubunParent + "_" + gubunName[node.NodeSequence];

                }
                if (node.IsParent)
                {
                    MakeNames(tree.GetChildList(node), node.Gubun, node.EnumName);
                }
            }

        }

        public bool MakeTree(string[] mainTree)
        {
            this.mainTree = mainTree;
            if (!IsValidData())
                return false;

            List<string> nodes = new List<string>(mainTree);

            TreeNode firstNode = new TreeNode(-1, 0);
            firstNode.ColumnNumber = 3;
            firstNode = GetNewNode(nodes, firstNode, true,true);
            SetParnetNode(firstNode, firstNode,true);

            MakeTreeRecursive(nodes, firstNode, tree);

            List<TreeNode> siblings = tree.GetSiblings(firstNode);
            MakeNames(siblings, "","");

            return isSuccessedForMaking=true;
        }

        private TreeNode MakeTreeRecursive(List<string> originNodes, TreeNode presentNode, Tree tree)
        {
            List<int> sameDepthNodes = GetSameDepthNodes(originNodes, presentNode.NodeSequence);

            List<TreeNode> depthedList = new List<TreeNode>();
            depthedList.Add(presentNode);
            tree.TreeMap.Add(sameDepthNodes[0], depthedList);

            for(int i=0; i < sameDepthNodes.Count; i++)
            {
                int nodeSeq = sameDepthNodes[i];

                //base contidion
                if (originNodes.Count - 1 <= nodeSeq)
                    continue;
                
                int depthGap = GetDepthGap(nodeSeq, nodeSeq + 1);

                if (depthGap == 1)
                {
                    TreeNode parentNode = null;
                    if (tree.containsNode(nodeSeq))
                        parentNode = tree.GetNode(nodeSeq);
                    else
                    {
                        presentNode = parentNode = GetNewNode(originNodes, presentNode, false, true);
                        
                        tree.PutNodeToMap(parentNode.NodeSequence, parentNode);
                        depthedList.Add(parentNode);
                    }

                    bool _isParent = isParent(originNodes, presentNode.NodeSequence+1);
                    TreeNode headNode = GetNewNode(originNodes, presentNode, true, _isParent);
                    SetHeadNode(headNode, presentNode);
                    SetParnetNode(parentNode, headNode, false);

                    presentNode = MakeTreeRecursive(originNodes, headNode, tree);
                }
                else if(depthGap==0)
                {
                    TreeNode siblingNode = GetNewNode(originNodes, presentNode, false, false);
                    SetSilblingNode(siblingNode, presentNode);

                    tree.PutNodeToMap(siblingNode.NodeSequence, siblingNode);
                    depthedList.Add(siblingNode);

                    presentNode = siblingNode;
                }
            }

            depthedList[depthedList.Count - 1].IsLastSon = true;
            return presentNode;
        }

        private List<int> GetSameDepthNodes(List<string> nodes, int nodeSeq)
        {
            List<int> indexs = new List<int>();

            int presentDepth = GetDepth(nodes[nodeSeq]);
            for (int i = nodeSeq; i < nodes.Count; i++)
            {
                int depthGap = GetDepth(nodes[i]) - presentDepth;
                if (depthGap == 0)
                    indexs.Add(i);
                else if (depthGap < 0)
                    break;
            }
            return indexs;
        }

        private void AppendEnumName(TreeNode presentNode, TreeNode parentNode, string appededName)
        {
            presentNode.EnumName += parentNode.EnumName + "_" + appededName;
        }

        private void SetParnetNode(TreeNode parentNode, TreeNode headNode, bool isFirstNode = false)
        {
            parentNode.ChildNode = headNode;
            parentNode.IsParent = true;
            parentNode.IsLastSon = false;
            parentNode.IsFinal = false;

            if (isFirstNode)
            {
                parentNode.IsHead = true;
                parentNode.EnumName = enumName[0];
            }
            else
            {
                parentNode.IsHead = false;
            }
        }

        private void SetHeadNode(TreeNode presentNode, TreeNode prevNode)
        {
            presentNode.IsHead = true;
            presentNode.IsParent = false;
            presentNode.ParentNode = prevNode;
        }

        private void SetSilblingNode(TreeNode presentNode, TreeNode prevNode)
        {
 
            prevNode.IsHead = false;
            prevNode.IsParent = false;

        }

        private bool isParent(List<string> originNodes, int nodeSeq)
        {
            if (originNodes.Count - 1 == nodeSeq)
                return false;

            return GetDepthGap(nodeSeq, nodeSeq + 1) == 1 ? true : false;
        }

        private TreeNode GetNewNode(List<string> originNodes, TreeNode presentNode, bool isNewHeadNode, bool isNewParentNode)
        {
            TreeNode newNode = new TreeNode(presentNode.NodeSequence + 1);
            int presentIdx = newNode.NodeSequence;

            if (mainTree[presentIdx].IndexOf("[x]") > 0)
                newNode.IsVirtualNode = true;
            else
                newNode.IsVirtualNode = false;
                        
            if (wizard1.ChkAutoGubun.CheckState == CheckState.Unchecked)
            {
                if (gubunName[presentIdx].Length > 0)
                    newNode.Gubun = gubunName[presentIdx];
                else
                {
                    MessageBox.Show("구분코드는 필수로 기입해야합니다.");
                    wizard1.RichGubun.Focus();
                    wizard1.RichGubun.SelectionStart = wizard1.RichGubun.GetLenghtAsLineNumber(presentIdx);
                    RemoveAll();
                    return null;
                }
            }
            else if (wizard1.ChkAutoGubun.CheckState == CheckState.Checked)
            {
                newNode.Gubun = GetGubunNameAutomatically(wizard1.RichGubun.Lines[presentIdx - 1]);
            }

            if (wizard1.ChkAutoEnum.CheckState == CheckState.Unchecked)
            {

                if (enumValue[presentIdx].Length > 0)
                    newNode.EnumNumber = int.Parse(enumValue[presentIdx]);
                else
                {
                    MessageBox.Show("enum값은 필수로 기입해야합니다.");
                    wizard1.RichEnum.Focus();
                    wizard1.RichEnum.SelectionStart = wizard1.RichEnum.GetLenghtAsLineNumber(presentIdx);
                    RemoveAll();
                    return null;
                }
            }
            else if (wizard1.ChkAutoEnum.CheckState == CheckState.Checked)
            {
                newNode.EnumNumber = presentNode.EnumNumber + gubunDepthGap;
            }

            if (isNewHeadNode && !isNewParentNode)
            {
                newNode.Depth = presentNode.Depth + 1;
                newNode.ColumnNumber = presentNode.ColumnNumber;
            }
            else if (isNewParentNode)
            {
                newNode.ColumnNumber = presentNode.ColumnNumber;
                newNode.Depth = GetDepth(originNodes[newNode.NodeSequence]);
            }
            else
            {
                newNode.ColumnNumber = presentNode.ColumnNumber + 1;
                newNode.Depth = presentNode.Depth;
            }

            newNode.ColumnName = GetColumnName(presentIdx, isNewParentNode);
            newNode.VariableName = GetVariableName(presentIdx, isNewParentNode);

            return newNode;
        }

        private string GetVariableName(int presentIdx, bool isParentNode)
        {
            string varName = "";
            if (isParentNode)
            {
                if (wizard1.ChkAutoVar.CheckState == CheckState.Unchecked)
                {

                    if (variableName[presentIdx].Length == 0)
                        varName = "";
                    else
                    {
                        MessageBox.Show("부모에 변수명은 넣을 수 없습니다.");
                        wizard1.RichVar.Focus();
                        wizard1.RichVar.SelectionStart = wizard1.RichVar.GetLenghtAsLineNumber(presentIdx);
                        RemoveAll();
                        return "";
                    }
                }
                else if (wizard1.ChkAutoVar.CheckState == CheckState.Checked)
                {
                    varName = "";
                }
            }
            else
            {
                if (wizard1.ChkAutoVar.CheckState == CheckState.Unchecked)
                {
                    if (variableName[presentIdx].Length > 0)
                        varName = variableName[presentIdx];
                    else
                    {
                        MessageBox.Show("변수명은 필수로 기입해야합니다.");
                        wizard1.RichVar.Focus();
                        wizard1.RichVar.SelectionStart = wizard1.RichVar.GetLenghtAsLineNumber(presentIdx);
                        RemoveAll();
                        return "";
                    }
                }
                else if (wizard1.ChkAutoVar.CheckState == CheckState.Checked)
                {
                    varName = mainTree[presentIdx];
                }

            }
            return varName;


        }

        private string GetColumnName(int presentIdx, bool isParentNode)
        {
            string colname = "";
            if (isParentNode)
            {
                if (wizard1.ChkAutoCol.CheckState == CheckState.Unchecked)
                {

                    if (columnName[presentIdx].Length == 0)
                        colname = "";
                    else
                    {
                        MessageBox.Show("부모에 컬럼명을 넣을 수 없습니다.");
                        wizard1.RichCol.Focus();
                        wizard1.RichCol.SelectionStart = wizard1.RichCol.GetLenghtAsLineNumber(presentIdx);
                        RemoveAll();
                        return "";
                    }
                }
                else if (wizard1.ChkAutoCol.CheckState == CheckState.Checked)
                {
                    colname = "";
                }
            }
            else
            {
                if (wizard1.ChkAutoCol.CheckState == CheckState.Unchecked)
                {
                    if (columnName[presentIdx].Length > 0)
                        colname = columnName[presentIdx];
                    else
                    {
                        MessageBox.Show("컬럼명은 필수로 기입해야합니다.");
                        wizard1.RichCol.Focus();
                        wizard1.RichCol.SelectionStart = wizard1.RichCol.GetLenghtAsLineNumber(presentIdx);
                        RemoveAll();
                        return "";
                    }
                }
                else if (wizard1.ChkAutoCol.CheckState == CheckState.Checked)
                {
                    colname = mainTree[presentIdx];
                }

            }
            return colname;

        }

        private int GetDepth(string str)
        {
            int depth = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\t')
                    depth++;
                else
                    break;
            }
            return depth;
        }

        private int GetDepthGap(string parent, string child)
        {
            return GetDepth(child) - GetDepth(parent);
        }

        private int GetDepthGap(int parent, int child)
        {
            return GetDepthGap(mainTree[parent],mainTree[child]);
        }

        private string GetGubunNameAutomatically(string str)
        {
            Random rdm = new Random();
            string g = "";
            g += (char)('A' + rdm.Next('Z' - 'A' + 1));
            return g;
        }

        private void RemoveAll()
        {

        }

    }
}
