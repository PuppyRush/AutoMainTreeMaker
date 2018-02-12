using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using AutoMainTreeMaker.SourceMaker;

namespace AutoMainTreeMaker.Database
{
    public partial class Dialog_Database : Form
    {
        Dialog_MappingData mappingDlg;
        Dialog_ColumnNumberAndRecordset colRecordDlg;
        List<TreeNode> orderedNode;
        Tree mainTree;
        List<string> recordsetNames;

        public Dialog_Database(Tree mainTree, List<string> rsList, Dialog_ColumnNumberAndRecordset dlg )
        {
            InitializeComponent();
            recordsetNames = rsList;
            mappingDlg = new Dialog_MappingData(this);
            comboBoxDB.SelectedIndex = 0;

            this.orderedNode = mainTree.GetOrderedNodeAsNodeSequence();
            this.mainTree = mainTree;
            colRecordDlg = dlg;

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
                    str = node.ParamName;
                    break;
                case "COLUMN_NO":
                    if (node.ColumnNumber == Dialog_ColumnNumberAndRecordset.DEFAULT_COL_NUMBER)
                        str = "";
                    else
                        str = node.ColumnNumber.ToString();
                    break;
                case "COLUMN_NAME":
                    str = node.ColumnName;
                    break;
                case "TREE_DEPTH":
                    str = node.Depth.ToString();
                    break;
                case "PARAM_TYPE":
                    str = "34";
                    break;
                case "DISPLAY_SEQ":
                    if (node.IsVirtualNode)
                        str = "-1";
                    else
                        str = node.DisplaySeq.ToString();
                    break;
                case "IS_DBLCLICK":
                    if (node.IsParent)
                        str = "0";
                    else
                        str = "1";
                    break;
                case "IS_DRAG":
                    if (node.IsParent)
                        str = "0";
                    else
                        str = "1";
                    break;
                case "IS_FAVORITE":
                    if (node.IsParent)
                        str = "0";
                    else
                        str = "1";
                    break;
                case "IS_FILTER":
                    str = "1";
                    break;
                case "IS_FILTERING":
                    if (node.IsParent)
                        str = "0";
                    else
                        str = "1";
                    break;
                case "IS_CORRELATION":
                    if (node.IsParent)
                        str = "0";
                    else
                        str = "1";
                    break;
                case "IS_SETTING":
                    str = "1";
                    break;
                case "IS_DEBUG":
                    str = "N";
                    break;
                case "IS_USED":
                    str = "Y";
                    break;
                case "ICON_NO":
                    if (node.IsParent)
                        str = "3";
                    else
                        str = "0";
                    break;
                case "GUBUN_CODE":
                case "GL_CODE":
                case "ML_CODE":
                    str = node.Gubun;
                    break;
                case "RS_NAME":
                    str = node.RecordsetFileName;
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
            return;
            this.Hide();
            mappingDlg.Init(recordsetNames,mainTree);
            mappingDlg.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            colRecordDlg.Show();
        }
    }
}

