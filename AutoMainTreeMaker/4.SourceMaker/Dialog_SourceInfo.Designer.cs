namespace AutoMainTreeMaker._4.SourceMaker
{
    partial class Dialog_SourceInfo
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
            this.cRichTextbox1 = new AutoMainTreeMaker.CRichTextbox();
            this.cRichTextbox2 = new AutoMainTreeMaker.CRichTextbox();
            this.SuspendLayout();
            // 
            // cRichTextbox1
            // 
            this.cRichTextbox1.IsChanged = false;
            this.cRichTextbox1.IsDrawingLine = false;
            this.cRichTextbox1.IsEditMode = true;
            this.cRichTextbox1.IsNumeric = false;
            this.cRichTextbox1.Location = new System.Drawing.Point(12, 21);
            this.cRichTextbox1.Name = "cRichTextbox1";
            this.cRichTextbox1.Size = new System.Drawing.Size(154, 388);
            this.cRichTextbox1.TabIndex = 0;
            this.cRichTextbox1.Text = "";
            // 
            // cRichTextbox2
            // 
            this.cRichTextbox2.IsChanged = false;
            this.cRichTextbox2.IsDrawingLine = false;
            this.cRichTextbox2.IsEditMode = true;
            this.cRichTextbox2.IsNumeric = false;
            this.cRichTextbox2.Location = new System.Drawing.Point(181, 21);
            this.cRichTextbox2.Name = "cRichTextbox2";
            this.cRichTextbox2.Size = new System.Drawing.Size(78, 388);
            this.cRichTextbox2.TabIndex = 1;
            this.cRichTextbox2.Text = "";
            // 
            // Dialog_SourceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 418);
            this.Controls.Add(this.cRichTextbox2);
            this.Controls.Add(this.cRichTextbox1);
            this.Name = "Dialog_SourceInfo";
            this.Text = "Dialog_SourceInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private CRichTextbox cRichTextbox1;
        private CRichTextbox cRichTextbox2;
    }
}