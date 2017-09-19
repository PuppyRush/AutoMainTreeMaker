namespace AutoMainTreeMaker.SourceMaker
{
    partial class HelpForm_SourfeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm_SourfeInfo));
            this.cRichTextbox1 = new AutoMainTreeMaker.CRichTextbox();
            this.SuspendLayout();
            // 
            // cRichTextbox1
            // 
            this.cRichTextbox1.IsChanged = false;
            this.cRichTextbox1.IsDrawingLine = false;
            this.cRichTextbox1.IsEditMode = true;
            this.cRichTextbox1.IsNumeric = false;
            this.cRichTextbox1.Location = new System.Drawing.Point(12, 12);
            this.cRichTextbox1.Name = "cRichTextbox1";
            this.cRichTextbox1.ReadOnly = true;
            this.cRichTextbox1.Size = new System.Drawing.Size(489, 265);
            this.cRichTextbox1.TabIndex = 0;
            this.cRichTextbox1.Text = resources.GetString("cRichTextbox1.Text");
            // 
            // HelpForm_SourfeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 289);
            this.Controls.Add(this.cRichTextbox1);
            this.Name = "HelpForm_SourfeInfo";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CRichTextbox cRichTextbox1;
    }
}