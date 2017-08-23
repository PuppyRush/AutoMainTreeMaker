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

        private string [] mainTree;
        private string [] enumValue;
        private string[] enumName;

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

        public Dialog_ResultForSource(string [] mainTree, string[] enumValue, string[] enumName)
        {
            InitializeComponent();
            
            richs = new List<CRichTextbox>();

            richs.Add(richMainTree);
            richs.Add(richEnumName);

            richInterface = new CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            this.mainTree = mainTree;
            this.enumValue = enumValue;
            this.enumName = enumName;

            richMainTree.Lines = mainTree;
        }

        private void MakeSource()
        {


        }

        public int GetLengthestEnumName()
        {
            int max = -1;
            foreach(string s in this.enumName)
            {
                if (max < s.Length)
                    max = s.Length;
            }
            return max;

        }

        private void chkAutoEnumName_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
                richEnumName.Enabled = false;
            else
                richEnumName.Enabled = true;
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
                columnRecordsetDlg = new Dialog_ColumnNumberAndRecordset(tree, mainTree);

            columnRecordsetDlg.Show();
        }
    }
}
