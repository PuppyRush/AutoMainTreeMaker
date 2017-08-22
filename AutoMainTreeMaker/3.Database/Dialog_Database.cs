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
        public Dialog_Database(List<TreeNode> orderedNode)
        {
            InitializeComponent();


            
        }

        private void comboBoxDB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxDB.SelectedIndex > 0)
            {

            }
        }
    }
}
