using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMainTreeMaker
{
    public class TreeNode
    {

        //변수상의 순서. 0부터 시작이다.
        private int nodeSequence;

        private bool isParent;
        private bool isHead;
        private bool isLastSon;
        private bool isFinal;

        private bool isVirtualNode;
        private int enumNumber;
        private int displaySeq;
        private int depth;
        private int columnNumber;
        private string recordsetFileName;
        private string paramName;
        private string variableName;
        private string gubun;
        private string columnName;
        private string enumName;

        private TreeNode parentNode;
        private TreeNode childNode;

        public int DisplaySeq
        {
            get { return displaySeq; }
            set { displaySeq = value; }
        }


        
        public bool IsVirtualNode
        {
            get { return isVirtualNode; }
            set { isVirtualNode = value; }
        }

        
        public bool IsParent
        {
            get { return isParent; }
            set { isParent = value; }
        }


        
        public int NodeSequence
        {
            get { return nodeSequence; }
            set { nodeSequence = value; }
        }

        
        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }


        public int ColumnNumber
        {
            get { return columnNumber; }
            set { columnNumber = value; }
        }

        
        public int EnumNumber
        {
            get { return enumNumber; }
            set { enumNumber = value; }
        }

        
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }

        
        public string Gubun
        {
            get { return gubun; }
            set { gubun = value; }
        }

        
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        public bool IsHead
        {
            get
            {
                return isHead;
            }

            set
            {
                isHead = value;
            }
        }

        public bool IsLastSon
        {
            get
            {
                return isLastSon;
            }

            set
            {
                isLastSon = value;
            }
        }

        public bool IsFinal
        {
            get
            {
                return isFinal;
            }

            set
            {
                isFinal = value;
            }
        }

        public string EnumName
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

        public TreeNode ParentNode
        {
            get
            {
                return parentNode;
            }

            set
            {
                parentNode = value;
            }
        }

        public TreeNode ChildNode
        {
            get
            {
                return childNode;
            }

            set
            {
                childNode = value;
            }
        }

        public string ParamName
        {
            get
            {
                return paramName;
            }

            set
            {
                paramName = value;
            }
        }

        public string RecordsetFileName
        {
            get
            {
                return recordsetFileName;
            }

            set
            {
                recordsetFileName = value;
            }
        }

        public TreeNode(int nodeSeq)
        {
            nodeSequence = nodeSeq;
        }

        public TreeNode(int nodeSeq, int depth)
        {
            
            if (isVirtualNode)
            {
                displaySeq = -1;
                depth = -1;
            }
            else
                this.depth = depth;

            this.nodeSequence = nodeSeq;
        }

    }
}
