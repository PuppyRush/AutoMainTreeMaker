using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMainTreeMaker.Database
{
    public partial class Dialog_Database : Form
    {

        List<TreeNode> orderedNode;

        public Dialog_Database(List<TreeNode> orderedNode)
        {
            InitializeComponent();
            comboBoxDB.SelectedIndex = 0;

            this.orderedNode = orderedNode;
            InitDataViewForLTE();
        }

        public void InitDataViewForLTE()
        {
            dataGrid.Rows.Clear();
            foreach (TreeNode node in orderedNode)
            {
                var idx = dataGrid.Rows.Add();
                var row = dataGrid.Rows[idx];

                var columnsName = dataGrid.GetHeaderNameOfColumns();
                var param = new List<string>();
                foreach(string str in columnsName)
                {

                    var name = GetStringFromTreeVariableOf(str, node);
                    row.Cells[str].Value = name;
                    row.Tag = node.NodeSequence;
                }

                
            }
            
        }

        private string GetStringFromTreeVariableOf(string headerName,TreeNode node)
        {
            string str = "";
            switch (headerName)
            {
                case "PARAM_CODE":
                    str = node.EnumNumber.ToString();
                    break;
                case "PARAM_NAME":
                    str = node.ColumnName;
                    break;
                case "COLUMN_NO":
                    str = node.ColumnNumber.ToString();
                    break;
                default:
                    str = "";
                    break;

            }
            return str;
        }

        private void comboBoxDB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxDB.SelectedIndex > 0)
            {

            }
        }
    }
}
