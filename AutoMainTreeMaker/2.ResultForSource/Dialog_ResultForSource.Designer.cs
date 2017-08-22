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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richMainTree
            // 
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsEditMode = true;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(12, 34);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.ReadOnly = true;
            this.richMainTree.Size = new System.Drawing.Size(795, 404);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.Text = "";
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
            this.btnBack.Location = new System.Drawing.Point(327, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- 뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(432, 454);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 41);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "다음 ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Dialog_ResultForSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richMainTree);
            this.Name = "Dialog_ResultForSource";
            this.Text = "Dialog_ResultForSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRichTextbox richMainTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}