using System.Collections.Generic;

using System;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {
        //ColumnSequence가 키.

        private Dictionary<int, TreeNode> nodeMap;
        private Dictionary<int, List<TreeNode>> tree;

        public Tree()
        {
            NodeMap = new Dictionary<int, TreeNode>();
            TreeMap = new Dictionary<int, List<TreeNode>>();

        }

        internal Dictionary<int, List<TreeNode>> TreeMap
        {
            get
            {
                return tree;
            }


            set
            {
                tree = value;

            }
        }

        public Dictionary<int, TreeNode> NodeMap
        {
            get
            {
                return nodeMap;
            }

            set
            {
                nodeMap = value;
            }
        }

        public void PutNodeToMap(int nodeSequence, TreeNode node)
        {
            NodeMap[nodeSequence] = node;
        }

        public TreeNode GetNode(int nodeSequece)
        {
            if (NodeMap.ContainsKey(nodeSequece))
                return NodeMap[nodeSequece];

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
                        PutNodeToMap(nodeSequece, node);
                        return node;
                    }
                }
            }

            return null;
        }

        public bool containsNode(int nodeSeq)
        {
            return tree.ContainsKey(nodeSeq);
                
        }

        public List<TreeNode> GetChildList(TreeNode parentNode)
        {
            return TreeMap[parentNode.ChildNode.NodeSequence];
        }

        public List<TreeNode> GetSiblings(TreeNode sibling)
        {
            if (TreeMap.ContainsKey(sibling.NodeSequence))
                return TreeMap[sibling.NodeSequence];
            else
            {
                foreach(List<TreeNode> list in TreeMap.Values)
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
            List<TreeNode> firstSiblings = GetSiblings(GetNode(0));
            return GetOrderedNodeAsNodeSequence_Recursive(firstSiblings);
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
    }
}
