using System.Collections.Generic;

using System;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {
        //ColumnSequence가 키.

        private int nodeCount;
        private bool isChanged;

        private List<TreeNode> orderedNode;
        private Dictionary<int, TreeNode> nodeMap;

        /// <summary>
        /// key는 형제노드들의 첫번째 nodeSequence입니다.
        /// </summary>
        private Dictionary<int, List<TreeNode>> tree;

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

        public Tree()
        {
            isChanged = true;
            orderedNode = new List<TreeNode>();
            nodeMap = new Dictionary<int, TreeNode>();
            tree = new Dictionary<int, List<TreeNode>>();

        }

 
        public void AddNode(TreeNode node)
        {
            if (!nodeMap.ContainsKey(node.NodeSequence))
            {
                NodeCount++;
            }
            nodeMap[node.NodeSequence] = node;
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

            return silblings;
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
                        AddNode(nodeSequece, node);
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
            return tree[parentNode.ChildNode.NodeSequence];
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
        
    }
}
