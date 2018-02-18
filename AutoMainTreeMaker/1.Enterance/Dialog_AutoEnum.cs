using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    public partial class AutoEnumDianlog : Form
    {

        private string preStartingEnum;
        private string preinterval;

        public AutoEnumDianlog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }


     

        private void startingEnum_TextChanged(object sender, EventArgs e)
        {
            if (startingEnum.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(startingEnum.Text, "\\D"))
            {
                MessageBox.Show("Input only numerics only");
                startingEnum.Text = preStartingEnum;
            }
            else
            {
                preStartingEnum = startingEnum.Text;
            }
        }

        private void interval_TextChanged(object sender, EventArgs e)
        {
            if (interval.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(interval.Text, "\\D"))
            {
                MessageBox.Show("Input only numerics only");
                interval.Text = preinterval;
            }
            else
            {
                preinterval = interval.Text;
            }
        }
    }
}
