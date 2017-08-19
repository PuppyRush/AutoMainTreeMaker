using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public partial class Dialog_ResultForSource : Form
    {

        private string [] mainTree;
        private string [] enumValue;
        private string[] enumName;

        CRichTextBoxInterface richInterface;
        List<CRichTextbox> richs;

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
    }
}
