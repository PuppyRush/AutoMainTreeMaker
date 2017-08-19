
namespace AutoMainTreeMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_MainTree));
            this.label_tree = new System.Windows.Forms.Label();
            this.label_enum = new System.Windows.Forms.Label();
            this.label_Col = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.labelGubun = new System.Windows.Forms.Label();
            this.label1_variable = new System.Windows.Forms.Label();
            this.BtnMakeTree = new System.Windows.Forms.Button();
            this.chkAutoEnum = new System.Windows.Forms.CheckBox();
            this.chkAutoCol = new System.Windows.Forms.CheckBox();
            this.chkAutoGubun = new System.Windows.Forms.CheckBox();
            this.chkAutoVar = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richLineNumber = new AutoMainTreeMaker.CRichTextbox();
            this.richVar = new AutoMainTreeMaker.CRichTextbox();
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
            this.label_tree.Location = new System.Drawing.Point(228, 19);
            this.label_tree.Name = "label_tree";
            this.label_tree.Size = new System.Drawing.Size(70, 19);
            this.label_tree.TabIndex = 4;
            this.label_tree.Text = "MainTree";
            // 
            // label_enum
            // 
            this.label_enum.AutoSize = true;
            this.label_enum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enum.Location = new System.Drawing.Point(509, 19);
            this.label_enum.Name = "label_enum";
            this.label_enum.Size = new System.Drawing.Size(81, 18);
            this.label_enum.TabIndex = 5;
            this.label_enum.Text = "Enum Value";
            // 
            // label_Col
            // 
            this.label_Col.AutoSize = true;
            this.label_Col.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Col.Location = new System.Drawing.Point(605, 19);
            this.label_Col.Name = "label_Col";
            this.label_Col.Size = new System.Drawing.Size(96, 18);
            this.label_Col.TabIndex = 7;
            this.label_Col.Text = "Column Name";
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Dotum", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnNext.Location = new System.Drawing.Point(608, 471);
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
            this.labelGubun.Location = new System.Drawing.Point(875, 19);
            this.labelGubun.Name = "labelGubun";
            this.labelGubun.Size = new System.Drawing.Size(89, 18);
            this.labelGubun.TabIndex = 12;
            this.labelGubun.Text = "Gubun Name";
            // 
            // label1_variable
            // 
            this.label1_variable.AutoSize = true;
            this.label1_variable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_variable.Location = new System.Drawing.Point(1075, 19);
            this.label1_variable.Name = "label1_variable";
            this.label1_variable.Size = new System.Drawing.Size(99, 18);
            this.label1_variable.TabIndex = 15;
            this.label1_variable.Text = "Variable Name";
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
            this.chkAutoEnum.Location = new System.Drawing.Point(512, 423);
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
            this.chkAutoCol.Location = new System.Drawing.Point(617, 423);
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
            this.chkAutoGubun.Location = new System.Drawing.Point(883, 423);
            this.chkAutoGubun.Name = "chkAutoGubun";
            this.chkAutoGubun.Size = new System.Drawing.Size(72, 16);
            this.chkAutoGubun.TabIndex = 19;
            this.chkAutoGubun.Text = "자동생성";
            this.chkAutoGubun.UseVisualStyleBackColor = true;
            this.chkAutoGubun.CheckedChanged += new System.EventHandler(this.ChkAutoGubun_CheckedChanged);
            // 
            // chkAutoVar
            // 
            this.chkAutoVar.AutoSize = true;
            this.chkAutoVar.Location = new System.Drawing.Point(1088, 423);
            this.chkAutoVar.Name = "chkAutoVar";
            this.chkAutoVar.Size = new System.Drawing.Size(72, 16);
            this.chkAutoVar.TabIndex = 20;
            this.chkAutoVar.Text = "자동생성";
            this.chkAutoVar.UseVisualStyleBackColor = true;
            this.chkAutoVar.CheckedChanged += new System.EventHandler(this.ChkAutoVar_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 24);
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
            // richLineNumber
            // 
            this.richLineNumber.IsChanged = false;
            this.richLineNumber.IsDrawingLine = false;
            this.richLineNumber.IsNumeric = false;
            this.richLineNumber.Location = new System.Drawing.Point(12, 41);
            this.richLineNumber.Name = "richLineNumber";
            this.richLineNumber.Size = new System.Drawing.Size(45, 376);
            this.richLineNumber.TabIndex = 21;
            this.richLineNumber.TabStop = false;
            this.richLineNumber.Text = "";
            // 
            // richVar
            // 
            this.richVar.AcceptsTab = true;
            this.richVar.IsChanged = false;
            this.richVar.IsDrawingLine = false;
            this.richVar.IsNumeric = false;
            this.richVar.Location = new System.Drawing.Point(1066, 41);
            this.richVar.Name = "richVar";
            this.richVar.Size = new System.Drawing.Size(209, 376);
            this.richVar.TabIndex = 14;
            this.richVar.TabStop = false;
            this.richVar.Text = resources.GetString("richVar.Text");
            this.richVar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richVar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richGubun
            // 
            this.richGubun.AcceptsTab = true;
            this.richGubun.IsChanged = false;
            this.richGubun.IsDrawingLine = false;
            this.richGubun.IsNumeric = false;
            this.richGubun.Location = new System.Drawing.Point(866, 41);
            this.richGubun.Name = "richGubun";
            this.richGubun.Size = new System.Drawing.Size(194, 376);
            this.richGubun.TabIndex = 11;
            this.richGubun.TabStop = false;
            this.richGubun.Text = resources.GetString("richGubun.Text");
            this.richGubun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richGubun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richCol
            // 
            this.richCol.AcceptsTab = true;
            this.richCol.IsChanged = false;
            this.richCol.IsDrawingLine = false;
            this.richCol.IsNumeric = false;
            this.richCol.Location = new System.Drawing.Point(596, 41);
            this.richCol.Name = "richCol";
            this.richCol.Size = new System.Drawing.Size(264, 376);
            this.richCol.TabIndex = 3;
            this.richCol.TabStop = false;
            this.richCol.Text = resources.GetString("richCol.Text");
            this.richCol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richCol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richEnum
            // 
            this.richEnum.AcceptsTab = true;
            this.richEnum.IsChanged = false;
            this.richEnum.IsDrawingLine = false;
            this.richEnum.IsNumeric = true;
            this.richEnum.Location = new System.Drawing.Point(508, 41);
            this.richEnum.Name = "richEnum";
            this.richEnum.Size = new System.Drawing.Size(82, 376);
            this.richEnum.TabIndex = 1;
            this.richEnum.TabStop = false;
            this.richEnum.Text = resources.GetString("richEnum.Text");
            this.richEnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richEnum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // richMainTree
            // 
            this.richMainTree.AcceptsTab = true;
            this.richMainTree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(63, 41);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.Size = new System.Drawing.Size(439, 376);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.TabStop = false;
            this.richMainTree.Text = resources.GetString("richMainTree.Text");
            this.richMainTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richMainTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // Wizard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 537);
            this.Controls.Add(this.richLineNumber);
            this.Controls.Add(this.chkAutoVar);
            this.Controls.Add(this.chkAutoGubun);
            this.Controls.Add(this.chkAutoCol);
            this.Controls.Add(this.chkAutoEnum);
            this.Controls.Add(this.BtnMakeTree);
            this.Controls.Add(this.label1_variable);
            this.Controls.Add(this.richVar);
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
            this.Name = "Wizard1";
            this.Text = "Wizard1";
            this.Resize += new System.EventHandler(this.Wizard1_Resize);
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
        private CRichTextbox richVar;
        private System.Windows.Forms.Label label_tree;
        private System.Windows.Forms.Label label_enum;
        private System.Windows.Forms.Label label_Col;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label labelGubun;
        private System.Windows.Forms.Label label1_variable;
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
        private System.Windows.Forms.CheckBox chkAutoVar;
        private CRichTextbox richLineNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;

        public System.Windows.Forms.CheckBox ChkAutoVar
        {
            get { return chkAutoVar; }
            set { chkAutoVar = value; }
        }

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

        public CRichTextbox RichVar
        {
            get
            {
                return richVar;
            }

            set
            {
                richVar = value;
            }
        }
    }
}

