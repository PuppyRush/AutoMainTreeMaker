
namespace AutoMainTreeMaker.MainTree
{
    public partial class Dialog_MainTree
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tree = new System.Windows.Forms.Label();
            this.label_enum = new System.Windows.Forms.Label();
            this.label_Col = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.labelGubun = new System.Windows.Forms.Label();
            this.BtnMakeTree = new System.Windows.Forms.Button();
            this.chkAutoEnum = new System.Windows.Forms.CheckBox();
            this.chkAutoCol = new System.Windows.Forms.CheckBox();
            this.chkAutoGubun = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAutoEnumName = new System.Windows.Forms.CheckBox();
            this.richEnumName = new AutoMainTreeMaker.CRichTextbox();
            this.richLineNumber = new AutoMainTreeMaker.CRichTextbox();
            this.richGubun = new AutoMainTreeMaker.CRichTextbox();
            this.richCol = new AutoMainTreeMaker.CRichTextbox();
            this.richEnum = new AutoMainTreeMaker.CRichTextbox();
            this.richMainTree = new AutoMainTreeMaker.CRichTextbox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tree
            // 
            this.label_tree.AutoSize = true;
            this.label_tree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tree.Location = new System.Drawing.Point(228, 17);
            this.label_tree.Name = "label_tree";
            this.label_tree.Size = new System.Drawing.Size(70, 19);
            this.label_tree.TabIndex = 4;
            this.label_tree.Text = "MainTree";
            // 
            // label_enum
            // 
            this.label_enum.AutoSize = true;
            this.label_enum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enum.Location = new System.Drawing.Point(755, 18);
            this.label_enum.Name = "label_enum";
            this.label_enum.Size = new System.Drawing.Size(81, 18);
            this.label_enum.TabIndex = 5;
            this.label_enum.Text = "Enum Value";
            // 
            // label_Col
            // 
            this.label_Col.AutoSize = true;
            this.label_Col.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Col.Location = new System.Drawing.Point(925, 17);
            this.label_Col.Name = "label_Col";
            this.label_Col.Size = new System.Drawing.Size(96, 18);
            this.label_Col.TabIndex = 7;
            this.label_Col.Text = "Column Name";
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnNext.Location = new System.Drawing.Point(459, 466);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(175, 41);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "다음 진행하기";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // labelGubun
            // 
            this.labelGubun.AutoSize = true;
            this.labelGubun.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGubun.Location = new System.Drawing.Point(1243, 17);
            this.labelGubun.Name = "labelGubun";
            this.labelGubun.Size = new System.Drawing.Size(89, 18);
            this.labelGubun.TabIndex = 12;
            this.labelGubun.Text = "Gubun Name";
            // 
            // BtnMakeTree
            // 
            this.BtnMakeTree.Location = new System.Drawing.Point(223, 423);
            this.BtnMakeTree.Name = "BtnMakeTree";
            this.BtnMakeTree.Size = new System.Drawing.Size(75, 23);
            this.BtnMakeTree.TabIndex = 16;
            this.BtnMakeTree.Text = "트리만들기";
            this.BtnMakeTree.UseVisualStyleBackColor = true;
            this.BtnMakeTree.Click += new System.EventHandler(this.BtnMakeTree_Click);
            // 
            // chkAutoEnum
            // 
            this.chkAutoEnum.AutoSize = true;
            this.chkAutoEnum.Location = new System.Drawing.Point(759, 423);
            this.chkAutoEnum.Name = "chkAutoEnum";
            this.chkAutoEnum.Size = new System.Drawing.Size(72, 16);
            this.chkAutoEnum.TabIndex = 17;
            this.chkAutoEnum.Text = "자동생성";
            this.chkAutoEnum.UseVisualStyleBackColor = true;
            this.chkAutoEnum.CheckedChanged += new System.EventHandler(this.ChkAutoEnum_CheckedChanged);
            // 
            // chkAutoCol
            // 
            this.chkAutoCol.AutoSize = true;
            this.chkAutoCol.Enabled = false;
            this.chkAutoCol.Location = new System.Drawing.Point(949, 427);
            this.chkAutoCol.Name = "chkAutoCol";
            this.chkAutoCol.Size = new System.Drawing.Size(72, 16);
            this.chkAutoCol.TabIndex = 18;
            this.chkAutoCol.Text = "자동생성";
            this.chkAutoCol.UseVisualStyleBackColor = true;
            this.chkAutoCol.CheckedChanged += new System.EventHandler(this.ChkAutoCol_CheckedChanged);
            // 
            // chkAutoGubun
            // 
            this.chkAutoGubun.AutoSize = true;
            this.chkAutoGubun.Enabled = false;
            this.chkAutoGubun.Location = new System.Drawing.Point(1201, 427);
            this.chkAutoGubun.Name = "chkAutoGubun";
            this.chkAutoGubun.Size = new System.Drawing.Size(72, 16);
            this.chkAutoGubun.TabIndex = 19;
            this.chkAutoGubun.Text = "자동생성";
            this.chkAutoGubun.UseVisualStyleBackColor = true;
            this.chkAutoGubun.CheckedChanged += new System.EventHandler(this.ChkAutoGubun_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.Location = new System.Drawing.Point(592, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enum Name";
            // 
            // chkAutoEnumName
            // 
            this.chkAutoEnumName.AutoSize = true;
            this.chkAutoEnumName.Enabled = false;
            this.chkAutoEnumName.Location = new System.Drawing.Point(595, 424);
            this.chkAutoEnumName.Name = "chkAutoEnumName";
            this.chkAutoEnumName.Size = new System.Drawing.Size(72, 16);
            this.chkAutoEnumName.TabIndex = 24;
            this.chkAutoEnumName.Text = "자동생성";
            this.chkAutoEnumName.UseVisualStyleBackColor = true;
            // 
            // richEnumName
            // 
            this.richEnumName.IsChanged = false;
            this.richEnumName.IsDrawingLine = false;
            this.richEnumName.IsEditMode = true;
            this.richEnumName.IsNumeric = false;
            this.richEnumName.Location = new System.Drawing.Point(576, 41);
            this.richEnumName.Name = "richEnumName";
            this.richEnumName.Size = new System.Drawing.Size(175, 377);
            this.richEnumName.TabIndex = 23;
            this.richEnumName.TabStop = false;
            this.richEnumName.Text = "";
            this.richEnumName.WordWrap = false;
            // 
            // richLineNumber
            // 
            this.richLineNumber.IsChanged = false;
            this.richLineNumber.IsDrawingLine = false;
            this.richLineNumber.IsEditMode = true;
            this.richLineNumber.IsNumeric = true;
            this.richLineNumber.Location = new System.Drawing.Point(12, 41);
            this.richLineNumber.Name = "richLineNumber";
            this.richLineNumber.ReadOnly = true;
            this.richLineNumber.Size = new System.Drawing.Size(45, 376);
            this.richLineNumber.TabIndex = 21;
            this.richLineNumber.TabStop = false;
            this.richLineNumber.Text = "";
            // 
            // richGubun
            // 
            this.richGubun.AcceptsTab = true;
            this.richGubun.IsChanged = false;
            this.richGubun.IsDrawingLine = false;
            this.richGubun.IsEditMode = true;
            this.richGubun.IsNumeric = false;
            this.richGubun.Location = new System.Drawing.Point(1194, 39);
            this.richGubun.Name = "richGubun";
            this.richGubun.Size = new System.Drawing.Size(194, 376);
            this.richGubun.TabIndex = 11;
            this.richGubun.TabStop = false;
            this.richGubun.Text = "";
            this.richGubun.WordWrap = false;
            this.richGubun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richGubun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richCol
            // 
            this.richCol.AcceptsTab = true;
            this.richCol.IsChanged = false;
            this.richCol.IsDrawingLine = false;
            this.richCol.IsEditMode = true;
            this.richCol.IsNumeric = false;
            this.richCol.Location = new System.Drawing.Point(845, 41);
            this.richCol.Name = "richCol";
            this.richCol.Size = new System.Drawing.Size(343, 376);
            this.richCol.TabIndex = 3;
            this.richCol.TabStop = false;
            this.richCol.Text = "";
            this.richCol.WordWrap = false;
            this.richCol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richCol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richEnum
            // 
            this.richEnum.AcceptsTab = true;
            this.richEnum.IsChanged = false;
            this.richEnum.IsDrawingLine = false;
            this.richEnum.IsEditMode = true;
            this.richEnum.IsNumeric = true;
            this.richEnum.Location = new System.Drawing.Point(757, 40);
            this.richEnum.Name = "richEnum";
            this.richEnum.Size = new System.Drawing.Size(82, 375);
            this.richEnum.TabIndex = 1;
            this.richEnum.TabStop = false;
            this.richEnum.Text = "";
            this.richEnum.WordWrap = false;
            this.richEnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richEnum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richMainTree
            // 
            this.richMainTree.AcceptsTab = true;
            this.richMainTree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsEditMode = true;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(63, 41);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.Size = new System.Drawing.Size(507, 376);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.TabStop = false;
            this.richMainTree.Text = "";
            this.richMainTree.WordWrap = false;
            this.richMainTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richMainTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // Dialog_MainTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAutoEnumName);
            this.Controls.Add(this.richEnumName);
            this.Controls.Add(this.richLineNumber);
            this.Controls.Add(this.chkAutoGubun);
            this.Controls.Add(this.chkAutoCol);
            this.Controls.Add(this.chkAutoEnum);
            this.Controls.Add(this.BtnMakeTree);
            this.Controls.Add(this.labelGubun);
            this.Controls.Add(this.richGubun);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.label_Col);
            this.Controls.Add(this.label_enum);
            this.Controls.Add(this.label_tree);
            this.Controls.Add(this.richCol);
            this.Controls.Add(this.richEnum);
            this.Controls.Add(this.richMainTree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dialog_MainTree";
            this.Text = "Wizard1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRichTextbox richEnum;
        private CRichTextbox richCol;
        private CRichTextbox richMainTree;
        private CRichTextbox richGubun;
        private System.Windows.Forms.Label label_tree;
        private System.Windows.Forms.Label label_enum;
        private System.Windows.Forms.Label label_Col;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label labelGubun;
        private System.Windows.Forms.Button BtnMakeTree;
        private System.Windows.Forms.CheckBox chkAutoEnum;

        public System.Windows.Forms.CheckBox ChkAutoEnum
        {
            get { return chkAutoEnum; }
            set { chkAutoEnum = value; }
        }
        private System.Windows.Forms.CheckBox chkAutoCol;

        public System.Windows.Forms.CheckBox ChkAutoCol
        {
            get { return chkAutoCol; }
            set { chkAutoCol = value; }
        }
        private System.Windows.Forms.CheckBox chkAutoGubun;

        public System.Windows.Forms.CheckBox ChkAutoGubun
        {
            get { return chkAutoGubun; }
            set { chkAutoGubun = value; }
        }
        private CRichTextbox richLineNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAutoEnumName;
        private CRichTextbox richEnumName;

        public CRichTextbox RichEnum
        {
            get
            {
                return richEnum;
            }

            set
            {
                richEnum = value;
            }
        }

        public CRichTextbox RichCol
        {
            get
            {
                return richCol;
            }

            set
            {
                richCol = value;
            }
        }

        public CRichTextbox RichMainTree
        {
            get
            {
                return richMainTree;
            }

            set
            {
                richMainTree = value;
            }
        }

        public CRichTextbox RichGubun
        {
            get
            {
                return richGubun;
            }

            set
            {
                richGubun = value;
            }
        }

    }
}

