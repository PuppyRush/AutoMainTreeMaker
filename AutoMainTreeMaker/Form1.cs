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
    public partial class Wizard1 : Form
    {

        Tree mainTree;

        List<RichTextBox> richs;

        public Wizard1()
        {
            InitializeComponent();

            mainTree = new Tree();
            
            richs = new List<RichTextBox>();
            richs.Add(RichMainTree);
            richs.Add(RichEnum);
            richs.Add(RichVar);
            richs.Add(RichCol);

            const int len = 20;
            foreach (CRichEditBox r in richs)
            {
                for (int l = 0; l < origins.Count; l++ )
                {
                    origins[l] = new string[len];
                    for (int i = 0; i < len; i++)
                    {
                        origins[l][i] = "\n";
                    }
                }
            }
            

        }

     
        private void Click_DrawLineAllForms(object sender, MouseEventArgs e)
        {
            CRichEditBox thisBox = (CRichEditBox)sender;
            int beginIndex = thisBox.SelectionStart;
            int currentLine = thisBox.GetLineFromCharIndex(beginIndex);
            foreach (CRichEditBox r in richs)
            {
                if (!sender.Equals(r))
                {
                    if (currentLine<= r.Lines.Length - 1)
                        r.DrawBlockedLineCurrently(beginIndex, currentLine);
                }
            }
        }

        private void KeyUp_DrawLineAllForms(object sender, KeyEventArgs e)
        {
            CRichEditBox thisBox = (CRichEditBox)sender;
            int beginIndex = thisBox.SelectionStart;
            int currentLine = thisBox.GetLineFromCharIndex(beginIndex);
            foreach (CRichEditBox r in richs)
            {
                if (!sender.Equals(r))
                {
                    if (currentLine <= r.Lines.Length - 1)
                        r.DrawBlockedLineCurrently(beginIndex, currentLine);
                }


            }
        }

        private void BtnMakeTree_Click(object sender, EventArgs e)
        {
            foreach (CRichEditBox r in richs)
            {
                if (r.IsChanged)
                {
                    mainTree.MainTree = RichMainTree.Lines;
                    mainTree.ColumnName = RichCol.Lines;
                    mainTree.GubunName = RichGubun.Lines;
                    mainTree.VariableName = RichVar.Lines;
                    mainTree.EnumValue = RichEnum.Lines;
                    mainTree.MakeTree();
                    break;
                }
            }
        }
    }
}
