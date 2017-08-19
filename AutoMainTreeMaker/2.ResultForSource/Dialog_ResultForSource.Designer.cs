namespace AutoMainTreeMaker
{
    partial class Dialog_ResultForSource
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
            this.richMainTree = new AutoMainTreeMaker.CRichTextbox();
            this.richEnumName = new AutoMainTreeMaker.CRichTextbox();
            this.btnMake = new System.Windows.Forms.Button();
            this.chkAutoEnumName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richResult
            // 
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(12, 34);
            this.richMainTree.Name = "richResult";
            this.richMainTree.ReadOnly = true;
            this.richMainTree.Size = new System.Drawing.Size(635, 404);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.Text = "";
            // 
            // richEnumName
            // 
            this.richEnumName.IsChanged = false;
            this.richEnumName.IsDrawingLine = false;
            this.richEnumName.IsNumeric = false;
            this.richEnumName.Location = new System.Drawing.Point(653, 34);
            this.richEnumName.Name = "richEnumName";
            this.richEnumName.Size = new System.Drawing.Size(153, 404);
            this.richEnumName.TabIndex = 1;
            this.richEnumName.Text = "";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(294, 454);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(244, 41);
            this.btnMake.TabIndex = 2;
            this.btnMake.Text = "소스 생성하기";
            this.btnMake.UseVisualStyleBackColor = true;
            // 
            // chkAutoEnumName
            // 
            this.chkAutoEnumName.AutoSize = true;
            this.chkAutoEnumName.Location = new System.Drawing.Point(698, 444);
            this.chkAutoEnumName.Name = "chkAutoEnumName";
            this.chkAutoEnumName.Size = new System.Drawing.Size(72, 16);
            this.chkAutoEnumName.TabIndex = 3;
            this.chkAutoEnumName.Text = "자동생성";
            this.chkAutoEnumName.UseVisualStyleBackColor = true;
            this.chkAutoEnumName.CheckedChanged += new System.EventHandler(this.chkAutoEnumName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "메인트리";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(181, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- 뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "단축이름";
            // 
            // Dialog_ResultForSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAutoEnumName);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.richEnumName);
            this.Controls.Add(this.richMainTree);
            this.Name = "Dialog_ResultForSource";
            this.Text = "Dialog_ResultForSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRichTextbox richMainTree;
        private CRichTextbox richEnumName;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.CheckBox chkAutoEnumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}