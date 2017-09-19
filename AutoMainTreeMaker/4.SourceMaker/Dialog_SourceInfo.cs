using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMainTreeMaker.Database;

namespace AutoMainTreeMaker.SourceMaker
{
    public partial class Dialog_SourceInfo : Form
    {
        MappingData mappedData;
        Dialog_MappingData dlgMappingData;
        CRichTextBoxInterface richInterface;
        Tree tree;

        public Dialog_SourceInfo(Dialog_MappingData dlg)
        {
            InitializeComponent();

            dlgMappingData = dlg;
            
            richInterface = new CRichTextBoxInterface();

            List<CRichTextbox> richs = new List<CRichTextbox>();
            richs.Add(richMainTree);
            richs.Add(richStruct);
        }

        public void Init(MappingData data, Tree tree)
        {
            this.tree = tree;
            FillTree();
            mappedData = data;
        }

        private void FillTree()
        {
            var nodes = tree.GetOrderedNodeAsNodeSequence();
            int nodeSeq = 0;

          
            
            for(int i=0; i < richStruct.Lines.Length; i++)
            {
                if(IsVariable( richStruct.Lines[i]))
                {
                    richMainTree.Lines[i] = nodes[nodeSeq].ParamName;
                    nodes[nodeSeq]
                }
                

                
            }
            
        }

        private bool IsVariable(string str)
        {
            var met = System.StringComparison.OrdinalIgnoreCase;
            if (String.Equals(str, "long", met) || String.Equals(str, "double", met) ||
                String.Equals(str, "char", met) || String.Equals(str, "short", met) ||
                String.Equals(str, "int", met) || String.Equals(str, "float", met) ||
                String.Equals(str, "byte", met))
                return true;
            else
                return false;

        }

        private int FindNextStructSeq(int beginIdx)
        {

        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LinkDataBetweenTreeAndStructre();

            var maker = new SourceMaker(tree);
            if (!maker.MakeSource())
                MessageBox.Show("파일 생성에 실패 하였습니다. 사유 : " + maker.filaCause);
            else
            {

            }
        }

        private void LinkDataBetweenTreeAndStructre()
        {



        }
    }
}
