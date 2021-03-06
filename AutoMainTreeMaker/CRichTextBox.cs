﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public class CRichTextbox : RichTextBox
    {

        #region field

        private int selectionStartForEdit;
        private int preLineIndex;
        private int preStrLen;
        private bool isEditMode;

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

        public bool IsEditMode
        {
            get
            {
                return isEditMode;
            }

            set
            {
                isEditMode = value;
            }
        }

        #endregion

        #region public Properties


        public CRichTextbox()
        {
            IsEditMode = true;
            isDrawingLine = false;
            IsNumeric = false;
            IsChanged = false;
            preLineIndex = preStrLen = 0;
            SelectionStart = 0;
            
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

        public void DrawBlockedLineCurrently(int currentLine=-1, bool isKeyPress = false)
        {
            if (Lines.Length == 0)
                return;

            if (isDrawingLine)
                return;

            isDrawingLine = true;

            if (currentLine == -1)
            {
                int beginIndex = SelectionStart;
                currentLine = GetLineFromCharIndex(beginIndex);
            }
            if(Lines.Length <= currentLine+1)
            {
                currentLine = Lines.Length - 1;
            }
            int lenghthOfLineCurrently = Lines[currentLine].Length;

            int lengthOfLines = GetLenghtAsLineNumber(currentLine);
            SelectionStart = GetFirstCharIndexFromLine(currentLine);
            SelectionLength = lenghthOfLineCurrently;
            SelectionBackColor = Color.DimGray;
            ForeColor = Color.Black;

            isDrawingLine = false;

            SaveNowSelectInfo();
        }

        public void SaveNowSelectInfo()
        {
            preLineIndex = this.GetLineFromCharIndex(this.SelectionStart);
            preStrLen = this.Lines[preLineIndex].Length;
        }

        public void EraseBlockedLineCurrently()
        {
            if (this.Lines.Length == 0)
                return;
            if (this.Lines.Length <= preLineIndex + 1)
            {
                preLineIndex = this.Lines.Length - 1;
            }
            SelectionStart = this.GetFirstCharIndexFromLine(preLineIndex);
            SelectionLength = this.preStrLen;
            SelectionBackColor = Color.White;
            ForeColor = Color.Black;
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
            else if( !(e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ))
            {                

                if (!isEditMode)
                {
                    EraseBlockedLineCurrently();
                    SelectionStart = selectionStartForEdit;
                    preStrLen = 0;
                    preLineIndex = GetLineFromCharIndex(SelectionStart);
                    SelectionLength = 0;
                }
                             
                
                IsEditMode = true;
            }             
            base.OnKeyDown(e);
        }

       

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //base.OnKeyUp(e);
            //switch (e.KeyData)
            //{
            //    case Keys.D0:
            //    case Keys.D1:
            //    case Keys.D2:
            //    case Keys.D3:
            //    case Keys.D4:
            //    case Keys.D5:
            //    case Keys.D6:
            //    case Keys.D7:
            //    case Keys.D8:
            //    case Keys.D9:
            //    case Keys.Up:
            //    case Keys.Down:
            //    case Keys.Left:
            //    case Keys.Right:
            //    case Keys.Enter:
            //        EraseBlockedLineCurrently();
            //        DrawBlockedLineCurrently();
            //        break;

            //    default:
            //        break;
            //}

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
            
            IsEditMode = false;
            selectionStartForEdit = SelectionStart;


            base.OnMouseClick(e);
            DrawBlockedLineCurrently();
        }

        public static implicit operator CRichTextbox(List<CRichTextbox> v)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
