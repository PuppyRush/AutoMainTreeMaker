using System.Collections.Generic;

using System;
using AutoMainTreeMaker.SourceMaker;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {

        public class TreeAsRecordset
        {
            private string recordfileName;
            private string subcode;
            private string shortcutName;

            List<TreeNode> nodeList;

            public string RecordfileName
            {
                get
                {
                    return recordfileName;
                }

                set
                {
                    recordfileName = value;
                }
            }

            public string Subcode
            {
                get
                {
                    return subcode;
                }

                set
                {
                    subcode = value;
                }
            }

            public string ShortcutName
            {
                get
                {
                    return shortcutName;
                }

                set
                {
                    shortcutName = value;
                }
            }

            public TreeAsRecordset(string rsName, List<TreeNode> list)
            {
                RecordfileName = rsName;
                nodeList = list;
            }


        }

        //ColumnSequence가 키.

        private bool isExistingVirtualNode;
        private int nodeCount;
        private bool isChanged;

        private List<TreeNode> orderedNode;
        private Dictionary<int, TreeNode> nodeMap;

        /// <summary>
        /// key는 형제노드들의 첫번째 nodeSequence입니다.
        /// </summary>
        private Dictionary<int, List<TreeNode>> tree;

        public Tree()
        {
            isChanged = true;
            orderedNode = new List<TreeNode>();
            nodeMap = new Dictionary<int, TreeNode>();
            tree = new Dictionary<int, List<TreeNode>>();
        }

        public int NodeCount
        {
            get
            {
                return nodeCount;
            }

            set
            {
                nodeCount = value;
            }
        }

        public bool IsExistingVirtualNode
        {
            get
            {
                return isExistingVirtualNode;
            }

            set
            {
                isExistingVirtualNode = value;
            }
        }

        public List<TreeNode> AddNode(int key, TreeNode node)
        {
            List<TreeNode> silblings = null;
            if (tree.ContainsKey(key))
            {
                bool isAdded = false;
                foreach(TreeNode _node in tree[key])
                {
                    if (_node.Equals(node))
                    {
                        isAdded = true;
                        break;
                    }
                }
                if (!isAdded)
                {
                    tree[key].Add(node);
                    NodeCount++;
                }
                silblings = tree[key];
            }
            else
            {
                NodeCount++;
                silblings = new List<TreeNode>();
                silblings.Add(node);
                tree.Add(key, silblings); 
            }
            if (silblings == null)
                throw new ArgumentNullException("TreeNode의 add 작업중 에러가 발생했습니다.");

            nodeMap[node.NodeSequence] = node;

            return silblings;
        }

        public int GetTopSiblingKey(int nodeSeq)
        {
            if (tree.ContainsKey(nodeSeq))
                return nodeSeq;

            foreach (List<TreeNode> list in tree.Values)
            {
                foreach(TreeNode node in list)
                {
                    if (node.NodeSequence == nodeSeq)
                        return list[0].NodeSequence;
                }
            }
            return -1;
        }

        public TreeNode GetNode(int nodeSequece)
        {
            if (nodeMap.ContainsKey(nodeSequece))
                return nodeMap[nodeSequece];

            if (tree.ContainsKey(nodeSequece))
            {
                return tree[nodeSequece][0];
            }

            Dictionary<int, List<TreeNode>>.KeyCollection keys = tree.Keys;
            foreach (int key in keys)
            {
                List<TreeNode> list = tree[key];
                foreach(TreeNode node in list)
                {
                    if (node.NodeSequence == nodeSequece)
                    {
                        nodeMap[nodeSequece] = node;
                        return node;
                    }
                }
            }

            return null;
        }

        public bool ContainsNode(int nodeSeq)
        {
        

            return nodeMap.ContainsKey(nodeSeq);
        }

        public List<TreeNode> GetChildList(TreeNode parentNode)
        {
            if (tree.ContainsKey(parentNode.ChildNode.NodeSequence))
                return tree[parentNode.ChildNode.NodeSequence];
            else
                return null;
        }

        public List<TreeNode> GetSiblings(TreeNode sibling)
        {
            if (tree.ContainsKey(sibling.NodeSequence))
                return tree[sibling.NodeSequence];
            else
            {
                foreach(List<TreeNode> list in tree.Values)
                {
                    foreach (TreeNode node in list)
                        if (node.Equals(sibling))
                            return list;
                }
            }
            return new List<TreeNode>();
        }

        public List<TreeNode> GetOrderedNodeAsNodeSequence()
        {
            if (isChanged)
            {
                List<TreeNode> firstSiblings = GetSiblings(GetNode(0));
                return orderedNode = GetOrderedNodeAsNodeSequence_Recursive(firstSiblings);
            }
            else {
                if(orderedNode.Count>0)
                    return orderedNode;
                else
                {
                    List<TreeNode> firstSiblings = GetSiblings(GetNode(0));
                    return orderedNode = GetOrderedNodeAsNodeSequence_Recursive(firstSiblings);
                }
            }
        }

        private List<TreeNode> GetOrderedNodeAsNodeSequence_Recursive(List<TreeNode> list)
        {
            List<TreeNode> _list = new List<TreeNode>();
            foreach (TreeNode node in list)
            {
                _list.Add(node);
                if (node.IsParent)
                {
                    List<TreeNode> childs = GetSiblings(node.ChildNode);
                    _list.AddRange(GetOrderedNodeAsNodeSequence_Recursive(childs));
                }
                    
            }

            return _list;
        }
        
        public List<TreeNode> GetOrderedLeafNode()
        {
            List<TreeNode> nodes = new List<TreeNode>();
            if (orderedNode.Count == 0)
                orderedNode = GetOrderedNodeAsNodeSequence();

            foreach(TreeNode node in orderedNode)
            {
                if (node.IsLeaf)
                    nodes.Add(node);
            }
            return nodes;
        }

        public static List<TreeAsRecordset> GetLeafNodeByRecordset(SourceMaker.MappingData datas)
        {
            var list = new List<TreeAsRecordset>();
            
            //var nodes = this


            return list;
        }
    }

   
}
