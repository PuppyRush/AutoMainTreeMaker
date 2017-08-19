using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace AutoMainTreeMaker
{

    

    class CRichTextBoxInterface
    {

        List<CRichTextbox> richs;

        public CRichTextBoxInterface()
        {
            richs = new List<CRichTextbox>();

    

            foreach (CRichTextbox r in richs)
            {
                r.SaveNowSelectInfo();
            }

        }

        public void SetInterface(List<CRichTextbox> richs)
        {
            this.richs = richs;
            
            foreach(CRichTextbox rich in this.richs)
            {
                rich.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
                rich.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            }
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
    }


}
