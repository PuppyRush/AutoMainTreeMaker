using AutoMainTreeMaker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public partial class Dialog_MainTree : Form
    {

        private bool isCreatedTree;

        TreeMaker maker;
        Tree mainTree;
        List<CRichTextbox> richs;
        CRichTextBoxInterface richInterface;

        public List<CRichTextbox> Richs
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

        public Dialog_MainTree()
        {
            InitializeComponent();

            isCreatedTree = false;

            richInterface = new CRichTextBoxInterface();

            richs = new List<CRichTextbox>();
            richs.Add(richMainTree);
            richs.Add(richEnum);
            richs.Add(richVar);
            richs.Add(richCol);
            richs.Add(richGubun);
            richs.Add(richLineNumber);
            richs.Add(richEnumName);

            richInterface.SetInterface(richs);

            SetLineNumbers();

            maker = new TreeMaker(this);
        }


        private void SetLineNumbers()
        {
            if (richs.Count == 0)
                new ArgumentException("배열의 크기가 0이상 이어야 합니다.");

            CRichTextbox rich = richs[0];
            foreach(CRichTextbox r in richs)
            {
                if (r.Lines.Length > r.Lines.Length)
                    rich = r;
            }

            int count = rich.Lines.Length;

            string[] lines = new string[count];
            for (int i = 0; i < count; i++)
                lines[i] = (i + 1).ToString();
            richLineNumber.Lines = lines;
        }
     
        private void Click_DrawLineAllForms(object sender, MouseEventArgs e)
        {
            CRichTextbox thisBox = (CRichTextbox)sender;
            int beginIndex = thisBox.SelectionStart;
            int currentLine = thisBox.GetLineFromCharIndex(beginIndex);
            foreach (CRichTextbox r in richs)
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
            CRichTextbox thisBox = (CRichTextbox)sender;
            int beginIndex = thisBox.SelectionStart;
            int currentLine = thisBox.GetLineFromCharIndex(beginIndex);
            foreach (CRichTextbox r in richs)
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
            foreach (CRichTextbox r in richs)
            {
                if (r.IsChanged)
                {
                    MessageBox.Show("목록들 중에 변경사항이 있습니다. 트리를 다시 생성합니다");
                    break;
                }
            }

                        
            maker.ColumnName = richCol.Lines;
            maker.GubunName = richGubun.Lines;
            maker.VariableName = richVar.Lines;
            maker.EnumValue = richEnum.Lines;
            maker.GubunName = richGubun.Lines;
            maker.EnumName = richEnumName.Lines;

            maker.MakeTree(richMainTree.Lines);
            if (maker.IsSuccessedForMaking)
            {
                mainTree = maker.Tree;
                isCreatedTree = maker.IsSuccessedForMaking;
                MessageBox.Show("트리생성에 성공하였습니다.");
            }
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

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if(isCreatedTree)
            {
                this.Hide();
                Dialog_ResultForSource dlg = new Dialog_ResultForSource(richMainTree.Lines, RichEnum.Lines, richCol.Lines );
                

                List<TreeNode> nodes = maker.Tree.GetOrderedNodeAsNodeSequence();
                string[] enums = new string[richMainTree.Lines.Length];

                for (int i=0; i < enums.Length; i++)
                {
                    enums[i] = nodes[i].EnumName;
                }

                dlg.MainTree = RichMainTree.Lines;
                dlg.EnumNumber = RichEnum.Lines;
                dlg.Enumname = enums;
                dlg.MainTreeDlg = this;
                dlg.MakeSource();
                dlg.ShowDialog();
            }

        }
    }
}
