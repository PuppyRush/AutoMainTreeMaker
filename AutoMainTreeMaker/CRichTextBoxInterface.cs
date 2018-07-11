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
            if (!(richs.Count >= 1))
                throw new ArgumentException("CRichInterface초기화에는 최소 한개 이상의 CRichBox가 있어야합니다.");

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
                if ( currentLine <= r.Lines.Length - 1)
                {
                    r.EraseBlockedLineCurrently();
                    r.DrawBlockedLineCurrently(currentLine);
                }

            }

        }

        private void KeyUp_DrawLineAllForms(object sender, KeyEventArgs e)
        {
            
        }


        public void EqualLinesToMaximumLine()
        {
            int max = GetMaxmimumLines();
            foreach(CRichTextbox rich in richs)
            {
                if(rich.Lines.Length < max)
                {
                    int adjustion = max - rich.Lines.Length;
                    for(int i=0; i < adjustion; i++)
                        rich.AppendText("\n");
                }
            }
        }

        private void SetScrollbar()
        {

           // richs[0].AutoScrollOffset = 
		}
		
        public int GetMaxmimumLines()
        {
            int lines = 0;
            foreach(var rich in richs)
            {
                if(lines < rich.Lines.Length)
                {
                    lines = rich.Lines.Length;
                }
            }
            return lines;
        }
    }


}
