using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMainTreeMaker.Database;
using AutoMainTreeMaker.MainTree;

namespace AutoMainTreeMaker.ResltForSource
{
    public partial class Dialog_ResultForSource : Form
    {

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
            PadRight(sources, maxi+5);
            maxi = GetLengthestOf(sources);
            //EqualizeStringLengths(sources, maxi);
            AppendBlanketAndEqualAndEnumNumberAndTree("        ", sources, enumNumber, mainTree);

            //maxi = GetLengthestOf(sources);
            //EqualizeStringLengths(sources, maxi);

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

        private void PadRight(string [] list, int len)
        {
            for(int i=0; i < list.Length; i++)
            {
                int neededTabCount = list[i].Length / 6;
                if (neededTabCount>1 && list[i].Length % 6==0)
                    neededTabCount -= (neededTabCount-1);
                list[i] = list[i] + new string('\t', 3-neededTabCount);

                //string str = "";
                //switch (neededTabCount)
                //{
                //    case 0:
                //        str = list[i] + new string('\t', 4);
                //        break;
                //    case 1:
                //        str = list[i] + new string('\t', 3);
                //        break;
                //    case 2:
                //        str = list[i] + new string('\t', 3);
                //        break;
                //}
                //list[i] = str;

            }
        }

        private void AppendBlanketAndEqualAndEnumNumberAndTree(string blankets,string [] dest, string [] enumNumber, string [] mainTree)
        {
            
            for (int i = 0; i < dest.Length; i++)
            {
                string s = dest[i];
                StringBuilder bld = new StringBuilder(s);
                bld.Append(blankets);
                bld.Append(" = ");
                bld.Append(enumNumber[i]);
                bld.Append(",");
                bld.Append(blankets);

                dest[i] = bld.ToString();
                bld.Clear();
                dest[i] = dest[i].PadRight(100);
                bld.Append(dest[i]);
                bld.Append("//        ");
                bld.Append(mainTree[i]);
                dest[i] = bld.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainTreeDlg.ShowDialog();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (columnRecordsetDlg == null)
                columnRecordsetDlg = new Dialog_ColumnNumberAndRecordset(tree, mainTree);

            columnRecordsetDlg.ShowDialog();
        }
    }
}
