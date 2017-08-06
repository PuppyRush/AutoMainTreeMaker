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
                    MessageBox.Show("목록들 중에 변경사항이 있습니다. 트리를 다시 생성합니다");
                    break;
                }
            }

            TreeMaker maker = new TreeMaker(this);

            
            maker.ColumnName = richCol.Lines;
            maker.GubunName = richGubun.Lines;
            maker.VariableName = richVar.Lines;
            maker.EnumValue = richEnum.Lines;

            maker.Do(richMainTree.Lines);
            if (maker.IsSuccessedForMaking)
                mainTree = maker.Tree;
            else
                MessageBox.Show("DOOOOOOOOOOOOHP");
                
        }

        private void Wizard1_Resize(object sender, EventArgs e)
        {
            
        }

        private void ChkAutoEnum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoEnum.CheckState == CheckState.Checked)
                RichEnum.Enabled = false;
            else if (chkAutoEnum.CheckState == CheckState.Unchecked)
                RichEnum.Enabled = true;


        }

        private void ChkAutoCol_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoCol.CheckState == CheckState.Checked)
                RichCol.Enabled = false;
            else if (chkAutoCol.CheckState == CheckState.Unchecked)
                RichCol.Enabled = true;
        }

        private void ChkAutoGubun_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoGubun.CheckState == CheckState.Checked)
                RichGubun.Enabled = false;
            else if (chkAutoGubun.CheckState == CheckState.Unchecked)
                RichGubun.Enabled = true;
        }

        private void ChkAutoVar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoVar.CheckState == CheckState.Checked)
                RichVar.Enabled = false;
            else if (chkAutoVar.CheckState == CheckState.Unchecked)
                RichVar.Enabled = true;
        }
    }
}
