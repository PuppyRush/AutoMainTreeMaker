using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

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

        private void btnMake_Click(object sender, EventArgs e)
        {
            ExportExcel_ForOneDataGrid(true, dataGrid);
        }

        private void ExportExcel_ForOneDataGrid(bool captions, DataGridView myDataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "TempName";
            saveFileDialog.DefaultExt = "xls";
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.InitialDirectory = "c:\\temp\\";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                int num = 0;
                object missingType = Type.Missing;

                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;

                string[] headers = new string[myDataGridView.ColumnCount];
                string[] columns = new string[myDataGridView.ColumnCount];

                for (int c = 0; c < myDataGridView.ColumnCount; c++)
                {
                    headers[c] = myDataGridView.Rows[0].Cells[c].OwningColumn.HeaderText.ToString();

                    if (c <= 25)
                    {
                        num = c + 65;
                        columns[c] = Convert.ToString((char)num);
                    }
                    else
                    {
                        columns[c] = Convert.ToString((char)(Convert.ToInt32(c / 26) - 1 + 65)) + Convert.ToString((char)(c % 26 + 65));
                    }
                }

                try
                {

                    objApp = new Excel.Application();
                    objBooks = objApp.Workbooks;
                    objBook = objBooks.Add(Missing.Value);
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                    if (captions)
                    {
                        for (int c = 0; c < myDataGridView.ColumnCount; c++)
                        {
                            range = objSheet.get_Range(columns[c] + "1", Missing.Value);
                            range.set_Value(Missing.Value, headers[c]);
                        }
                    }

                    for (int i = 0; i < myDataGridView.RowCount - 1; i++)
                    {
                        for (int j = 0; j < myDataGridView.ColumnCount; j++)
                        {
                            if (myDataGridView.Rows[i].Cells[j].Value == null)
                                continue;

                            range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2),
                                Missing.Value);
                            range.set_Value(Missing.Value,
                                myDataGridView.Rows[i].Cells[j].Value.ToString());

                        }
                    }
                    objApp.Visible = false;
                    objApp.UserControl = false;
                    objBook.SaveAs(@saveFileDialog.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                        missingType, missingType, missingType, missingType,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                        missingType, missingType, missingType, missingType, missingType);

                    objBook.Close(false, missingType, missingType);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Save Success!!!");
                }
                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, theException.Source);
                    MessageBox.Show(errorMessage, "Error");
                }
            }
        }

        private void btnMakeSource_Click(object sender, EventArgs e)
        {

            MessageBox.Show("아직 지원하지 않는 기능입니다.");
            return;


        }
    }
}
