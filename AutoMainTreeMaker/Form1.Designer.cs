
namespace AutoMainTreeMaker
{
    public partial class Wizard1
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
            this.BtnEnumAuto = new System.Windows.Forms.Button();
            this.BtnColumnAuto = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.richCol = new AutoMainTreeMaker.CRichEditBox();
            this.richEnum = new AutoMainTreeMaker.CRichEditBox();
            this.richMainTree = new AutoMainTreeMaker.CRichEditBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGubun = new System.Windows.Forms.Label();
            this.richGubun = new AutoMainTreeMaker.CRichEditBox();
            this.label1_variable = new System.Windows.Forms.Label();
            this.richVar = new AutoMainTreeMaker.CRichEditBox();
            this.BtnMakeTree = new System.Windows.Forms.Button();
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
            // BtnEnumAuto
            // 
            this.BtnEnumAuto.Location = new System.Drawing.Point(512, 423);
            this.BtnEnumAuto.Name = "BtnEnumAuto";
            this.BtnEnumAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnEnumAuto.TabIndex = 8;
            this.BtnEnumAuto.Text = "자동생성";
            this.BtnEnumAuto.UseVisualStyleBackColor = true;
            // 
            // BtnColumnAuto
            // 
            this.BtnColumnAuto.Location = new System.Drawing.Point(608, 423);
            this.BtnColumnAuto.Name = "BtnColumnAuto";
            this.BtnColumnAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnColumnAuto.TabIndex = 9;
            this.BtnColumnAuto.Text = "자동생성";
            this.BtnColumnAuto.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnNext.Location = new System.Drawing.Point(381, 492);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(175, 35);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "다음 진행하기";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // richCol
            // 
            this.richCol.AcceptsTab = true;
            this.richCol.IsChanged = false;
            this.richCol.IsDrawingLine = false;
            this.richCol.IsNumeric = false;
            this.richCol.Location = new System.Drawing.Point(596, 41);
            this.richCol.Name = "richCol";
            this.richCol.Size = new System.Drawing.Size(108, 376);
            this.richCol.TabIndex = 3;
            this.richCol.TabStop = false;
            this.richCol.Text = "";
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
            this.richEnum.Text = "";
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
            this.richMainTree.Location = new System.Drawing.Point(12, 41);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.Size = new System.Drawing.Size(490, 376);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.Text = "//New Main Tree\n//\tDepth는 Tab으로 구분.\n//\t동일 Depth은 같은 Tab 갯수로 구분.\n//\t\t현재의 Depth는 3." +
    "";
            this.richMainTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richMainTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "자동생성";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelGubun
            // 
            this.labelGubun.AutoSize = true;
            this.labelGubun.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGubun.Location = new System.Drawing.Point(719, 19);
            this.labelGubun.Name = "labelGubun";
            this.labelGubun.Size = new System.Drawing.Size(89, 18);
            this.labelGubun.TabIndex = 12;
            this.labelGubun.Text = "Gubun Name";
            // 
            // richGubun
            // 
            this.richGubun.AcceptsTab = true;
            this.richGubun.IsChanged = false;
            this.richGubun.IsDrawingLine = false;
            this.richGubun.IsNumeric = false;
            this.richGubun.Location = new System.Drawing.Point(710, 41);
            this.richGubun.Name = "richGubun";
            this.richGubun.Size = new System.Drawing.Size(108, 376);
            this.richGubun.TabIndex = 11;
            this.richGubun.TabStop = false;
            this.richGubun.Text = "";
            this.richGubun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richGubun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
            // 
            // label1_variable
            // 
            this.label1_variable.AutoSize = true;
            this.label1_variable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_variable.Location = new System.Drawing.Point(833, 19);
            this.label1_variable.Name = "label1_variable";
            this.label1_variable.Size = new System.Drawing.Size(99, 18);
            this.label1_variable.TabIndex = 15;
            this.label1_variable.Text = "Variable Name";
            // 
            // richVar
            // 
            this.richVar.AcceptsTab = true;
            this.richVar.IsChanged = false;
            this.richVar.IsDrawingLine = false;
            this.richVar.IsNumeric = false;
            this.richVar.Location = new System.Drawing.Point(824, 41);
            this.richVar.Name = "richVar";
            this.richVar.Size = new System.Drawing.Size(108, 376);
            this.richVar.TabIndex = 14;
            this.richVar.TabStop = false;
            this.richVar.Text = "";
            this.richVar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_DrawLineAllForms);
            this.richVar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_DrawLineAllForms);
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
            // Wizard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 539);
            this.Controls.Add(this.BtnMakeTree);
            this.Controls.Add(this.label1_variable);
            this.Controls.Add(this.richVar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGubun);
            this.Controls.Add(this.richGubun);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnColumnAuto);
            this.Controls.Add(this.BtnEnumAuto);
            this.Controls.Add(this.label_Col);
            this.Controls.Add(this.label_enum);
            this.Controls.Add(this.label_tree);
            this.Controls.Add(this.richCol);
            this.Controls.Add(this.richEnum);
            this.Controls.Add(this.richMainTree);
            this.Name = "Wizard1";
            this.Text = "Wizard1";
            this.Resize += new System.EventHandler(this.Wizard1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRichEditBox richEnum;
        private CRichEditBox richCol;
        private CRichEditBox richMainTree;
        private CRichEditBox richGubun;
        private CRichEditBox richVar;
        private System.Windows.Forms.Label label_tree;
        private System.Windows.Forms.Label label_enum;
        private System.Windows.Forms.Label label_Col;
        private System.Windows.Forms.Button BtnEnumAuto;
        private System.Windows.Forms.Button BtnColumnAuto;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGubun;
        private System.Windows.Forms.Label label1_variable;
        private System.Windows.Forms.Button BtnMakeTree;

        public CRichEditBox RichEnum
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

        public CRichEditBox RichCol
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

        public CRichEditBox RichMainTree
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

        public CRichEditBox RichGubun
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

        public CRichEditBox RichVar
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

