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
    }
}
