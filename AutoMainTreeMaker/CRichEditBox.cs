using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public class CRichEditBox : RichTextBox
    {

        #region field

        

        private bool isChanged;
        public bool IsChanged
        {
            get { return isChanged; }
            set { isChanged = value; }
        }


        private bool isNumeric;
        public bool IsNumeric
        {
            get { return isNumeric; }
            set { isNumeric = value; }
        }
        

        private bool isDrawingLine;
        public bool IsDrawingLine
        {
            get { return isDrawingLine; }
            set { isDrawingLine = value; }
        }

        #endregion

        #region public Properties


        public CRichEditBox()
        {
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            isDrawingLine = false;
            IsNumeric = false;
            IsChanged = false;
        }

        public bool IsNuemricString()
        {

            foreach (char c in Text)
            {
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '\n':
                    case '\t':
                        break;
                    default:
                        return false;
                }

            }
            return true;
        }

        public void DrawBlockedLineCurrently(int prevIndex, bool isKeyPress = false)
        {
            if (Lines.Length == 0)
                return;

            if (isDrawingLine)
                return;


            isDrawingLine = true;
            int beginIndex = SelectionStart;
            int line = GetLineFromCharIndex(beginIndex);

            int lenghthOfLineCurrently = Lines[line].Length;



            this.SelectionStart = 0;
            this.SelectionLength = Text.Length;
            this.SelectionBackColor = Color.White;
            this.ForeColor = Color.Black;

            int lengthOfPrevLines = GetLenghtAsLineNumber(line);


            this.SelectionStart = lengthOfPrevLines;
            this.SelectionLength = lenghthOfLineCurrently;
            this.SelectionBackColor = Color.DimGray;
            this.ForeColor = Color.Black;
            //Focus();

            this.SelectionStart = prevIndex;
            this.SelectionLength = 0;

            isDrawingLine = false;
        }

        public void DrawBlockedLineCurrently(int prevIndex, int currentLine, bool isKeyPress = false)
        {

            if (Lines.Length == 0)
                return;
            if (isDrawingLine)
                return;

            isDrawingLine = true;


            int lenghthOfLineCurrently = Lines[currentLine].Length;


            this.SelectionStart = 0;
            this.SelectionLength = Text.Length;
            this.SelectionBackColor = Color.White;
            this.ForeColor = Color.Black;

            int lengthOfPrevLines = GetLenghtAsLineNumber(currentLine);


            this.SelectionStart = lengthOfPrevLines;
            this.SelectionLength = lenghthOfLineCurrently + 1;
            this.SelectionBackColor = Color.DimGray;
            this.ForeColor = Color.Black;
            //Focus();

            this.SelectionStart = prevIndex;
            this.SelectionLength = 0;

            isDrawingLine = false;
        }

        public int GetLenghtAsLineNumber(int line)
        {

            int lengthOfPrevLines = 0;


            for (int i = 0; i < line && i < Lines.Length; i++)
            {
                lengthOfPrevLines += Lines[i].Length;
                lengthOfPrevLines += i;
            }

            return lengthOfPrevLines;
        }


        #endregion

        

        #region private Properties

    
        #endregion

        #region event

        protected override void OnKeyDown(KeyEventArgs e)
        {
           
            if (e.Shift && e.KeyCode == Keys.Tab)
            {
                int index = GetFirstCharIndexOfCurrentLine();
                int line = GetLineFromCharIndex(index);
                string str = Lines[line];
                if (str[0] == '\t')
                    str = str.Remove(0, 1);
                Lines[line] = str;
                return;
            }
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            switch (e.KeyData)
            {
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.Enter:
                    DrawBlockedLineCurrently(this.SelectionStart, true);
                    break;
                                    

                default:
                    break;
            }

          

            if (IsNumeric && Text.Length > 0 && !IsNuemricString())
            {
                if (e.KeyData == Keys.Space)
                    MessageBox.Show("공백은 올 수 없습니다..");
                else
                    MessageBox.Show("enum값으로는 숫자만 올 수 있습니다.");
                Text = Text.Remove(Text.Length - 1, 1);
                return;
            }

            IsChanged = true;
        }

   

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            DrawBlockedLineCurrently(this.SelectionStart);
        }

        #endregion
        
    }
}
