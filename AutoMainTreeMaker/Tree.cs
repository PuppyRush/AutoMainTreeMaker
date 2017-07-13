using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public class Tree
    {

        string[] mainTree;

        public string[] MainTree
        {
            get { return mainTree; }
            set { mainTree = value; }
        }

        string[] enumValue;

        public string[] EnumValue
        {
            get { return enumValue; }
            set { enumValue = value; }
        }

        string[] variableName;

        public string[] VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }

        string[] columnName;

        public string[] ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        string[] gubunName;

        public string[] GubunName
        {
            get { return gubunName; }
            set { gubunName = value; }
        }

        private string[] RemoveEmptyLine(string [] str)
        {
            List<string> newStr = new List<string>();

            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i].Length == 0)
                    count++;
                else
                    break;
            }

            for (int i = 0; i < str.Length - count; i++)
                newStr.Add(str[i]);

            return newStr.ToArray();                    
        }

        private bool IsValidData(Wizard1 wizard)
        {
            int NodeCount = mainTree.Length;

            char[] buf = new char[1];
            buf[0] = ' ';
  
            foreach(CRichEditBox r in wizard.Richs)
            {
                if (r.Equals(wizard.RichMainTree))
                    continue;
                r.Lines = RemoveEmptyLine(r.Lines);

                if(NodeCount != r.Lines.Length)
                {
                    r.Focus();
                    MessageBox.Show(r.Name + "목록이 트리와 불일치 합니다.");
                    return false;
                }
            }

         
            return true;
        }


        public bool MakeTree(Wizard1 wizard)
        {
            if (!IsValidData(wizard))
                return false;
            return true;
        }

    }
}
