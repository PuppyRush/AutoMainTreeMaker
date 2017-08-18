using AutoMainTreeMaker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public partial class Wizard1 : Form
    {

        Tree mainTree;

        List<CRichEditBox> richs;

        public List<CRichEditBox> Richs
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

            richs = new List<CRichEditBox>();
            richs.Add(richMainTree);
            richs.Add(richEnum);
            richs.Add(richVar);
            richs.Add(richCol);
            richs.Add(richGubun);
            richs.Add(richLineNumber);

            int count = GetEditBoxFromLines(richs).Lines.Length;

            string [] lines = new string[count];
            for (int i = 0; i < count; i++)
                lines[i] = (i + 1).ToString();
            richLineNumber.Lines = lines;

            foreach (CRichEditBox r in richs)
            {
                r.SaveNowSelectInfo();
            }
        }

        private CRichEditBox GetEditBoxFromLines(List<CRichEditBox> richs)
        {
            if (richs.Count == 0)
                new ArgumentException("배열의 크기가 0이상 이어야 합니다.");

            CRichEditBox rich = richs[0];
            foreach(CRichEditBox r in richs)
            {
                if (r.Lines.Length > r.Lines.Length)
                    rich = r;
            }

            return rich;
        }
     
        private void Click_DrawLineAllForms(object sender, MouseEventArgs e)
        {
            CRichEditBox thisBox = (CRichEditBox)sender;
            int beginIndex = thisBox.SelectionStart;
            int currentLine = thisBox.GetLineFromCharIndex(beginIndex);
            foreach (CRichEditBox r in richs)
            {
                if (currentLine <= r.Lines.Length - 1)
                {
                    r.EraseBlockedLineCurrently();
                    r.DrawBlockedLineCurrently(currentLine);
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

                if (currentLine <= r.Lines.Length - 1)
                {
                    r.EraseBlockedLineCurrently();
                    r.DrawBlockedLineCurrently(currentLine);
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
            maker.GubunName = richGubun.Lines;

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

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }
    }
}
