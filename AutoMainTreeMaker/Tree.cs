using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {

        public enum ResultFromMakeTree
        {
            END_TREE=-1,
            CONTINUED_NODE = 0,
            WRONG_TREE = 1
        }

        private Wizard1 wizard1;

        int gubunDepthGap;
        int gubunNodeGap;

        
        //ColumnSequence가 키.
        Dictionary<int, List<TreeNode>> tree;
        List<TreeNode> treeAsList;

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


        public Tree()
        {
            gubunDepthGap = 10;
            gubunNodeGap = 1;
            tree = new Dictionary<int, List<TreeNode>>();
            treeAsList = new List<TreeNode>();
        }
        

        private string[] RemoveEmptyLine(string [] str)
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

        private bool IsValidData()
        {
            int NodeCount = mainTree.Length;

            char[] buf = new char[1];
            buf[0] = ' ';
  
            foreach(CRichEditBox r in wizard1.Richs)
            {
                if (r.Equals(wizard1.RichMainTree))
                    continue;
                r.Lines = RemoveEmptyLine(r.Lines);

                if(NodeCount != r.Lines.Length)
                {
                    r.Focus();
                    MessageBox.Show(r.Name + "목록이 트리와 불일치 합니다.");
                    return false;
                }
            }

         
            return true;
        }


        public bool MakeTree(Wizard1 wizard)
        {
            wizard1 = wizard;

            if (!IsValidData())
                return false;

            TreeNode firstNode = new TreeNode(0, 1);
            firstNode = GetNewNode(firstNode,true);            

            List<TreeNode> list = new List<TreeNode>();
            list.Add(firstNode);
            tree.Add(firstNode.NodeSequence, list);

            List<string> nodes = new List<string>(mainTree);
            MakeTree_Recursive(nodes, firstNode);

            return true;
        }




        private void MakeTree_Recursive(List<string> nodes, TreeNode prevNode)
        {

            List<int> sameDepthNodes = GetSameDepthNodes(nodes, prevNode.NodeSequence);
            for (int i = 0; i < sameDepthNodes.Count; i++)
            {
                List<TreeNode> list = tree[sameDepthNodes[0]+1];
                TreeNode newNode = null;

                int presentIndex = sameDepthNodes[i];
                string parentString = nodes[presentIndex];
                string childString = nodes[presentIndex + 1];

                //base contidion
                if (nodes.Count <= prevNode.NodeSequence)
                    return;

                int depthGap = GetDepthGap(parentString, childString);
                if (depthGap == 0)
                {
                    newNode = GetNewNode(prevNode, false);
                    prevNode = newNode;
                    list.Add(newNode);
                }
                else if (depthGap == 1)
                {
                    List<TreeNode> newList = new List<TreeNode>();
                    newNode = GetNewNode(prevNode, true);
                    newList.Add(newNode);
                    tree.Add(newNode.NodeSequence, newList);

                    MakeTree_Recursive(nodes, newNode);
                }
                //if (Math.Abs(depthParent - depthChild) > 1)
                //{
                //    wizard1.RichMainTree.Focus();
                //    throw new NullReferenceException("트리의 깊이가 한번에 1보다 커질 수 없습니다.");
                //}
            }
        }

        private List<int> GetSameDepthNodes(List<string> nodes, int nodeSeq)
        {
            List<int> indexs = new List<int>();
            nodeSeq--;

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

        private TreeNode GetNewNode(TreeNode prevNode,bool isParent)
        {
            TreeNode node = new TreeNode(prevNode.NodeSequence + 1);
            int index = prevNode.NodeSequence;

            if (mainTree[index].IndexOf("[x]") > 0 )
                node.IsVirtualNode = true;
            else
                node.IsVirtualNode = false;

           

            ///

            if (wizard1.ChkAutoGubun.CheckState == CheckState.Unchecked)
            {

                if (gubunName[index].Length > 0)
                    node.Gubun = gubunName[index];
                else
                {
                    MessageBox.Show("구분코드는 필수로 기입해야합니다.");
                    wizard1.RichGubun.Focus();
                    wizard1.RichGubun.SelectionStart = wizard1.RichGubun.GetLenghtAsLineNumber(index);
                    RemoveAll();
                    return null;
                }
            }
            else if (wizard1.ChkAutoGubun.CheckState == CheckState.Checked)
            {
                node.Gubun = GetGubunNameAutomatically(wizard1.RichGubun.Lines[index - 1]);
            }

            ///

           

            ///

            if (wizard1.ChkAutoEnum.CheckState == CheckState.Unchecked)
            {

                if (enumValue[index].Length > 0)
                    node.EnumNumber = int.Parse(enumValue[index]);
                else
                {
                    MessageBox.Show("enum값은 필수로 기입해야합니다.");
                    wizard1.RichEnum.Focus();
                    wizard1.RichEnum.SelectionStart = wizard1.RichEnum.GetLenghtAsLineNumber(index);
                    RemoveAll();
                    return null;
                }
            }
            else if (wizard1.ChkAutoEnum.CheckState == CheckState.Checked)
            {
                node.EnumNumber = prevNode.EnumNumber + gubunDepthGap;
            }

            
            if (isParent)
            {

                node.ColumnNumber = -1;
                node.Depth = prevNode.Depth + 1;

                if (wizard1.ChkAutoCol.CheckState == CheckState.Unchecked)
                {

                    if (columnName[index].Length == 0)
                        node.ColumnName = "";
                    else
                    {
                        MessageBox.Show("부모에 컬럼명을 넣을 수 없습니다.");
                        wizard1.RichCol.Focus();
                        wizard1.RichCol.SelectionStart = wizard1.RichCol.GetLenghtAsLineNumber(index);
                        RemoveAll();
                        return null;
                    }
                }
                else if (wizard1.ChkAutoCol.CheckState == CheckState.Checked)
                {
                    node.ColumnName = "";
                }

                ///

                if (wizard1.ChkAutoVar.CheckState == CheckState.Unchecked)
                {
                    if (variableName[index].Length == 0)
                        node.VariableName = "";
                    else
                    {
                        MessageBox.Show("부모에 변수명은 넣을 수 없습니다.");
                        wizard1.RichVar.Focus();
                        wizard1.RichVar.SelectionStart = wizard1.RichVar.GetLenghtAsLineNumber(index);
                        RemoveAll();
                        return null;
                    }

                }
                else if (wizard1.ChkAutoVar.CheckState == CheckState.Checked)
                {
                    node.VariableName = "";
                }


            }//isParent
            else
            {

                node.ColumnNumber = prevNode.ColumnNumber + 1;
                node.Depth = prevNode.Depth;

                if (wizard1.ChkAutoCol.CheckState == CheckState.Unchecked)
                {

                    if (columnName[index].Length > 0)
                        node.ColumnName = columnName[index];
                    else
                    {
                        MessageBox.Show("부모에 컬럼명을 넣을 수 없습니다.");
                        wizard1.RichCol.Focus();
                        wizard1.RichCol.SelectionStart = wizard1.RichCol.GetLenghtAsLineNumber(index);
                        RemoveAll();
                        return null;
                    }
                }
                else if (wizard1.ChkAutoCol.CheckState == CheckState.Checked)
                {
                    node.ColumnName = "";
                }


                if (wizard1.ChkAutoVar.CheckState == CheckState.Unchecked)
                {
                    if (variableName[index].Length > 0)
                        node.VariableName = variableName[index];
                    else
                    {
                        MessageBox.Show("노드에는 변수명이 있어야합니다.");
                        wizard1.RichVar.Focus();
                        wizard1.RichVar.SelectionStart = wizard1.RichVar.GetLenghtAsLineNumber(index);
                        RemoveAll();
                        return null;
                    }

                }
                else if (wizard1.ChkAutoVar.CheckState == CheckState.Checked)
                {
                    node.VariableName = wizard1.RichVar.Lines[index - 1];
                }
            }//isParent else


            return node;
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
            return GetDepth(child)-GetDepth(parent);
        }

        private string GetGubunNameAutomatically(string str)
        {
            Random rdm = new Random();
            string g = "";
            g += (char) ('A' + rdm.Next('Z'-'A'+1));
            return g;
        }
        
        private void RemoveAll()
        {

        }
    }
}
