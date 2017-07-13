using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public partial class Wizard1 : Form
    {

        Tree mainTree;

        List<RichTextBox> richs;

        public List<RichTextBox> Richs
        {
            get
            {
                return richs;
            }

            set
            {
                richs = value;
            }
        }

        public Wizard1()
        {
            InitializeComponent();

            mainTree = new Tree();
            
            richs = new List<RichTextBox>();
            richs.Add(richMainTree);
            richs.Add(richEnum);
            richs.Add(richVar);
            richs.Add(richCol);
   
         
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
                    mainTree.MainTree = richMainTree.Lines;
                    mainTree.ColumnName = richCol.Lines;
                    mainTree.GubunName = richGubun.Lines;
                    mainTree.VariableName = richVar.Lines;
                    mainTree.EnumValue = richEnum.Lines;
                    mainTree.MakeTree(this);
                    break;
                }
            }
        }

        private void Wizard1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
