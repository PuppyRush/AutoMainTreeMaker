using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AutoMainTreeMaker.Database;
using AutoMainTreeMaker.MainTree;

namespace AutoMainTreeMaker.ResltForSource
{
    public partial class Dialog_ResultForSource : Form
    {

        private static int TAB_SPACE = 6;

        private string[] enumname;
        private string[] enumNumber;
        private string[] mainTree;

        private CRichTextBoxInterface richInterface;
        private List<CRichTextbox> richs;
        private Dialog_MainTree mainTreeDlg;
        private Dialog_ColumnNumberAndRecordset columnRecordsetDlg;
        private Tree tree;

        public Tree Tree
        {
            get { return tree; }
            set { tree = value; }
        }

        public Dialog_MainTree MainTreeDlg
        {
            get
            {
                return mainTreeDlg;
            }

            set
            {
                mainTreeDlg = value;
            }
        }

        public string[] Enumname
        {
            get
            {
                return enumname;
            }

            set
            {
                enumname = value;
            }
        }

        public string[] EnumNumber
        {
            get
            {
                return enumNumber;
            }

            set
            {
                enumNumber = value;
            }
        }

        public string[] MainTree
        {
            get
            {
                return mainTree;
            }

            set
            {
                mainTree = value;
            }
        }

        public Dialog_ResultForSource(string [] mainTree, string[] enumValue, string[] enumName)
        {
            InitializeComponent();
            
            richs = new List<CRichTextbox>();

            richs.Add(richMainTree);

            richInterface = new CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            richMainTree.Lines = mainTree;
        }

        public void MakeSource()
        {
            string[] sources = enumname;
            int maxi = GetLengthestOf(sources);
            PadRight(sources, maxi);

            AppendComment(mainTree);

            richTextCommnt.Lines = mainTree;
            richMainTree.Lines = sources;
        }

        private int GetLengthestOf(string [] list)
        {
            int max = -1;
            foreach(string s in list)
            {
                if (max < s.Length)
                    max = s.Length;
            }
            return max;

        }

        private void EqualizeStringLengths(string[] list, int len)
        {
            for (int i = 0; i < list.Length; i++)
            {
                int _len = list[i].Length;
                if (list[i].Length < len)
                    list[i] = list[i].Remove(len - 1, _len - len); 
            }
        }

        private void PadRight(string [] list, int maxLen)
        {
            for(int i=0; i < list.Length; i++)
            {
                var strLen = list[i].Length;
                int neededTabCount = (maxLen - strLen) / TAB_SPACE;
               // if ( ((maxLen - strLen) % TAB_SPACE) > 0)
                //    neededTabCount++;

                list[i] = list[i] + new string('\t', neededTabCount);

                //if (maxLen - strLen > 0)
                //    list[i] = list[i] + new string('\t', (maxLen-strLen) / TAB_SPACE + neededTabCount);
                //else
                //    list[i] = list[i] + new string('\t', (strLen - strLen) / TAB_SPACE + neededTabCount);
            }
        }

        private void AppendComment(string []maintree)
        {

            for (int i = 0; i < maintree.Length; i++ )
            {
                StringBuilder bld = new StringBuilder("//");
                bld.Append("\t\t");
                bld.Append(maintree[i]);
                maintree[i] = bld.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainTreeDlg.Show();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (columnRecordsetDlg == null)
            {
                columnRecordsetDlg = new Dialog_ColumnNumberAndRecordset(tree, mainTree,this);
            }
            columnRecordsetDlg.ShowDialog();
        }
    }
}
