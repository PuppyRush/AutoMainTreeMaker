using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMainTreeMaker
{
    class TreeNode
    {

        private int displaySeq;
        public int DisplaySeq
        {
            get { return displaySeq; }
            set { displaySeq = value; }
        }


        private bool isVirtualNode;
        public bool IsVirtualNode
        {
            get { return isVirtualNode; }
            set { isVirtualNode = value; }
        }

        private bool isParent;
        public bool IsParent
        {
            get { return isParent; }
            set { isParent = value; }
        }


        private int nodeSequence;
        public int NodeSequence
        {
            get { return nodeSequence; }
            set { nodeSequence = value; }
        }


        private int depth;
        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        private int columnNumber;
        public int ColumnNumber
        {
            get { return columnNumber; }
            set { columnNumber = value; }
        }

        private int enumNumber;
        public int EnumNumber
        {
            get { return enumNumber; }
            set { enumNumber = value; }
        }


        private string variableName;
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }


        private string gubun;
        public string Gubun
        {
            get { return gubun; }
            set { gubun = value; }
        }


        private string columnName;
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }



        public TreeNode(int nodeSeq)
        {
            nodeSequence = nodeSeq;
        }

        public TreeNode(int nodeSeq, int depth)
        {
            nodeSequence = nodeSeq;
            this.depth = depth;
        }

    }
}
