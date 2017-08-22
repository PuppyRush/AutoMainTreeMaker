using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMainTreeMaker.Database
{
    public partial class Dialog_ColumnNumberAndRecordset : Form
    {
        CRichTextBoxInterface richInterface;
        List<CRichTextbox> richs;
        Tree tree;

        Dialog_Database databaseDlg;

        public Dialog_ColumnNumberAndRecordset(Tree tree, string [] mainTree)
        {
            InitializeComponent();

            this.tree = tree;
            richMainTree.Lines = mainTree;

            richs = new List<CRichTextbox>();
            richs.Add(richMainTree);
            richs.Add(richColumnNumber);
            richs.Add(richRecordsetName);

            richInterface = new CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            //databaseDlg = new Dialog_Database();

        }

        public void Make()
        {


        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            databaseDlg.ShowDialog();
        }
      
    }
}
