using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    class CDataGridView : DataGridView
    {
           
        public int GetColumnNumberFrom(string columnName)
        {

            foreach (DataGridViewColumn col in Columns)
            {
                if (col.Name.Equals(columnName))
                    return col.Index;
            }
            return -1;

        }

       
        /// <summary>
        /// 헤더순서대로 리스트로 이름을 반환합니다.
        /// </summary>
        /// <returns></returns>
        public List<string> GetHeaderNameOfColumns()
        {
            List<string> names = new List<string>();
            foreach (DataGridViewColumn col in Columns)
            {
                names.Add(col.Name);
            }
            return names;
        }

    }
}
