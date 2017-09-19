
namespace AutoMainTreeMaker.Database
{
    partial class Dialog_Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDB = new System.Windows.Forms.ComboBox();
            this.dataGrid = new AutoMainTreeMaker.CDataGridView();
            this.PARAM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREE_DEPTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAM_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPLAY_SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_DBLCLICK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_DRAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_FAVORITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_FILTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_FILTERING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_CORRELATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_SETTING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_DEBUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_USED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICON_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRAPH_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAP_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEGEND_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUBUN_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BASE_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ML_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_PARSING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMakeSource = new System.Windows.Forms.Button();
            this.btnMakeExcel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDB
            // 
            this.comboBoxDB.FormattingEnabled = true;
            this.comboBoxDB.Items.AddRange(new object[] {
            "LTE",
            "OPTIS",
            "사용자정의"});
            this.comboBoxDB.Location = new System.Drawing.Point(30, 13);
            this.comboBoxDB.Name = "comboBoxDB";
            this.comboBoxDB.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDB.TabIndex = 0;
            this.comboBoxDB.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDB_SelectionChangeCommitted);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAM_CODE,
            this.PARAM_NAME,
            this.COLUMN_NAME,
            this.COLUMN_NO,
            this.TREE_DEPTH,
            this.PARAM_TYPE,
            this.DISPLAY_SEQ,
            this.IS_DBLCLICK,
            this.IS_DRAG,
            this.IS_FAVORITE,
            this.IS_FILTER,
            this.IS_FILTERING,
            this.IS_CORRELATION,
            this.IS_SETTING,
            this.IS_DEBUG,
            this.IS_USED,
            this.ICON_NO,
            this.REFERENCE_COL,
            this.GRAPH_TYPE,
            this.MAP_TYPE,
            this.LEGEND_TYPE,
            this.GUBUN_CODE,
            this.BASE_CODE,
            this.GL_CODE,
            this.ML_CODE,
            this.VERSION,
            this.RS_NAME,
            this.IS_PARSING});
            this.dataGrid.Location = new System.Drawing.Point(30, 49);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(959, 390);
            this.dataGrid.TabIndex = 1;
            // 
            // PARAM_CODE
            // 
            this.PARAM_CODE.HeaderText = "PARAM_CODE";
            this.PARAM_CODE.Name = "PARAM_CODE";
            // 
            // PARAM_NAME
            // 
            this.PARAM_NAME.HeaderText = "PARAM_NAME";
            this.PARAM_NAME.Name = "PARAM_NAME";
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            // 
            // COLUMN_NO
            // 
            this.COLUMN_NO.HeaderText = "COLUMN_NO";
            this.COLUMN_NO.Name = "COLUMN_NO";
            // 
            // TREE_DEPTH
            // 
            this.TREE_DEPTH.HeaderText = "TREE_DEPTH";
            this.TREE_DEPTH.Name = "TREE_DEPTH";
            // 
            // PARAM_TYPE
            // 
            this.PARAM_TYPE.HeaderText = "PARAM_TYPE";
            this.PARAM_TYPE.Name = "PARAM_TYPE";
            // 
            // DISPLAY_SEQ
            // 
            this.DISPLAY_SEQ.HeaderText = "DISPLAY_SEQ";
            this.DISPLAY_SEQ.Name = "DISPLAY_SEQ";
            // 
            // IS_DBLCLICK
            // 
            this.IS_DBLCLICK.HeaderText = "IS_DBLCLICK";
            this.IS_DBLCLICK.Name = "IS_DBLCLICK";
            // 
            // IS_DRAG
            // 
            this.IS_DRAG.HeaderText = "IS_DRAG";
            this.IS_DRAG.Name = "IS_DRAG";
            // 
            // IS_FAVORITE
            // 
            this.IS_FAVORITE.HeaderText = "IS_FAVORITE";
            this.IS_FAVORITE.Name = "IS_FAVORITE";
            // 
            // IS_FILTER
            // 
            this.IS_FILTER.HeaderText = "IS_FILTER";
            this.IS_FILTER.Name = "IS_FILTER";
            // 
            // IS_FILTERING
            // 
            this.IS_FILTERING.HeaderText = "IS_FILTERING";
            this.IS_FILTERING.Name = "IS_FILTERING";
            // 
            // IS_CORRELATION
            // 
            this.IS_CORRELATION.HeaderText = "IS_CORRELATION";
            this.IS_CORRELATION.Name = "IS_CORRELATION";
            // 
            // IS_SETTING
            // 
            this.IS_SETTING.HeaderText = "IS_SETTING";
            this.IS_SETTING.Name = "IS_SETTING";
            // 
            // IS_DEBUG
            // 
            this.IS_DEBUG.HeaderText = "IS_DEBUG";
            this.IS_DEBUG.Name = "IS_DEBUG";
            // 
            // IS_USED
            // 
            this.IS_USED.HeaderText = "IS_USED";
            this.IS_USED.Name = "IS_USED";
            // 
            // ICON_NO
            // 
            this.ICON_NO.HeaderText = "ICON_NO";
            this.ICON_NO.Name = "ICON_NO";
            // 
            // REFERENCE_COL
            // 
            this.REFERENCE_COL.HeaderText = "REFERENCE_COL";
            this.REFERENCE_COL.Name = "REFERENCE_COL";
            // 
            // GRAPH_TYPE
            // 
            this.GRAPH_TYPE.HeaderText = "GRAPH_TYPE";
            this.GRAPH_TYPE.Name = "GRAPH_TYPE";
            // 
            // MAP_TYPE
            // 
            this.MAP_TYPE.HeaderText = "MAP_TYPE";
            this.MAP_TYPE.Name = "MAP_TYPE";
            // 
            // LEGEND_TYPE
            // 
            this.LEGEND_TYPE.HeaderText = "LEGEND_TYPE";
            this.LEGEND_TYPE.Name = "LEGEND_TYPE";
            // 
            // GUBUN_CODE
            // 
            this.GUBUN_CODE.HeaderText = "GUBUN_CODE";
            this.GUBUN_CODE.Name = "GUBUN_CODE";
            // 
            // BASE_CODE
            // 
            this.BASE_CODE.HeaderText = "BASE_CODE";
            this.BASE_CODE.Name = "BASE_CODE";
            // 
            // GL_CODE
            // 
            this.GL_CODE.HeaderText = "GL_CODE";
            this.GL_CODE.Name = "GL_CODE";
            // 
            // ML_CODE
            // 
            this.ML_CODE.HeaderText = "ML_CODE";
            this.ML_CODE.Name = "ML_CODE";
            // 
            // VERSION
            // 
            this.VERSION.HeaderText = "VERSION";
            this.VERSION.Name = "VERSION";
            // 
            // RS_NAME
            // 
            this.RS_NAME.HeaderText = "RS_NAME";
            this.RS_NAME.Name = "RS_NAME";
            // 
            // IS_PARSING
            // 
            this.IS_PARSING.HeaderText = "IS_PARSING";
            this.IS_PARSING.Name = "IS_PARSING";
            // 
            // btnMakeSource
            // 
            this.btnMakeSource.Location = new System.Drawing.Point(579, 456);
            this.btnMakeSource.Name = "btnMakeSource";
            this.btnMakeSource.Size = new System.Drawing.Size(129, 52);
            this.btnMakeSource.TabIndex = 2;
            this.btnMakeSource.Text = "소스파일 생성하기";
            this.btnMakeSource.UseVisualStyleBackColor = true;
            this.btnMakeSource.Click += new System.EventHandler(this.btnMakeSource_Click);
            // 
            // btnMakeExcel
            // 
            this.btnMakeExcel.Location = new System.Drawing.Point(399, 456);
            this.btnMakeExcel.Name = "btnMakeExcel";
            this.btnMakeExcel.Size = new System.Drawing.Size(129, 52);
            this.btnMakeExcel.TabIndex = 3;
            this.btnMakeExcel.Text = "엑셀파일 생성하기";
            this.btnMakeExcel.UseVisualStyleBackColor = true;
            this.btnMakeExcel.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(219, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Dialog_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakeExcel);
            this.Controls.Add(this.btnMakeSource);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.comboBoxDB);
            this.Name = "Dialog_Database";
            this.Text = "Dialog_Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDB;
        private CDataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAM_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREE_DEPTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAM_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPLAY_SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_DBLCLICK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_DRAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_FAVORITE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_FILTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_FILTERING;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_CORRELATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_SETTING;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_DEBUG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_USED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICON_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAPH_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAP_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEGEND_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUBUN_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BASE_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GL_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn RS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_PARSING;
        private System.Windows.Forms.Button btnMakeSource;
        private System.Windows.Forms.Button btnMakeExcel;
        private System.Windows.Forms.Button btnBack;
    }
}