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

        const int MAX_COL_LEN = 100;
        const char COL_NAME_DELIMETER = '=';
        
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

        public void MakeNames(List<TreeNode> list, string gubunParent, string enumParent, string colParent)
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

                AppendColumName(node, colParent);

                if (node.IsParent)
                {
                    MakeNames(tree.GetChildList(node), node.Gubun, node.EnumName, node.ColumnName);
                    node.ColumnName = "";
                }

            }

        }

        public void AppendColumName(TreeNode node, string parentColumnName)
        {
            if(!parentColumnName.Equals(""))
                node.ColumnName = parentColumnName + "=" + columnName[node.NodeSequence];
            while(node.ColumnName.Length > MAX_COL_LEN)
            {
                int idx = node.ColumnName.IndexOf(COL_NAME_DELIMETER);
                node.ColumnName = node.ColumnName.Remove(0, idx);
            }
        }

        /// <summary>
        /// 부모노드는 DB상에서 column이름을 필요로 하지 않음.
        /// </summary>
        public void RemoveColumnNameOfParent()
        {
            List<TreeNode> list = tree.GetOrderedNodeAsNodeSequence();
            foreach(TreeNode node in list)
            {
                if (node.IsParent)
                    node.ColumnName = "";
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
            if (GetDepthGap(0, 1) == 1)
            {
                firstNode = GetNewNode(nodes, firstNode, true, true);
                SetParnetNode(firstNode, firstNode, true);
            }
            else
                firstNode = GetNewNode(nodes, firstNode, true, false);
            

            MakeTreeRecursive(nodes, firstNode, tree);

            List<TreeNode> siblings = tree.GetSiblings(firstNode);
            MakeNames(siblings, "","","");

            return isSuccessedForMaking=true;
        }

        private TreeNode MakeTreeRecursive(List<string> originNodes, TreeNode presentNode, Tree tree)
        {
            List<int> sameDepthNodes = GetSameDepthNodes(originNodes, presentNode.NodeSequence);

            List<TreeNode> depthedList = tree.AddNode(sameDepthNodes[0], presentNode);
            
            for(int i=0; i < sameDepthNodes.Count; i++)
            {
                int nodeSeq = sameDepthNodes[i];

                //base contidition
                if (originNodes.Count - 1 <= nodeSeq)
                {
                    TreeNode siblingNode = GetNewNode(originNodes, presentNode, false, false);
                    SetSilblingNode(siblingNode, presentNode);
                    tree.AddNode(sameDepthNodes[0], siblingNode);
                    presentNode = siblingNode;
                    break;
                }
                else if (tree.NodeCount == originNodes.Count)
                    break;
                
                int depthGap = GetDepthGap(nodeSeq, nodeSeq + 1);
                int nextDepthgap = -1;
                if (nodeSeq +2 != originNodes.Count)
                    nextDepthgap = GetDepthGap(nodeSeq + 1, nodeSeq + 2);

                if (depthGap == 1)
                {
                    TreeNode parentNode = null;
                    if (tree.ContainsNode(nodeSeq))
                    {
                        parentNode = tree.GetNode(nodeSeq);
                    }
                    else
                    {
                        presentNode = parentNode = GetNewNode(originNodes, presentNode, false, true);
                        tree.AddNode(sameDepthNodes[0], parentNode);
                    }

                    bool _isParent = isParent(originNodes, presentNode.NodeSequence+1);
                    TreeNode headNode = GetNewNode(originNodes, presentNode, true, _isParent);
                    SetHeadNode(headNode, presentNode);
                    SetParnetNode(parentNode, headNode, false);

                    presentNode = MakeTreeRecursive(originNodes, headNode, tree);
                    
                }
                else if (nextDepthgap == 1 && depthGap==0)
                {
                    TreeNode parentNode = presentNode = GetNewNode(originNodes, presentNode, false, true);
                    tree.AddNode(sameDepthNodes[0],  parentNode);
                }

                else if(depthGap==0)
                {
                    TreeNode siblingNode = GetNewNode(originNodes, presentNode, false, false);
                    SetSilblingNode(siblingNode, presentNode);
                
                    tree.AddNode(sameDepthNodes[0], siblingNode);
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

            newNode.Depth = GetDepth(originNodes[newNode.NodeSequence]);
            newNode.ParamName = newNode.ColumnName = GetColumnName(presentIdx, isNewParentNode);

            return newNode;
        }

        private string GetColumnName(int presentIdx, bool isParentNode)
        {
            string colname = "";
     
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
            return depth+1;
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
