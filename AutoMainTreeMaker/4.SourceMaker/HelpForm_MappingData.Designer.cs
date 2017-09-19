namespace AutoMainTreeMaker.SourceMaker
{
    partial class HelpForm_MappingData
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
            this.cRichTextbox1.Size = new System.Drawing.Size(361, 254);
            this.cRichTextbox1.TabIndex = 0;
            this.cRichTextbox1.Text = "메인트리에서 레코드이름에 해당하는 범위의 변수들에\n맵핑될 subcode,구조체를 기입하시면 됩니다.\n단축명은 구조체이름 대신에 사용될 define" +
    " 이름입니다.";
            // 
            // HelpForm_MappingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 88);
            this.Controls.Add(this.cRichTextbox1);
            this.Name = "HelpForm_MappingData";
            this.Text = "HelpForm_MappingData";
            this.ResumeLayout(false);

        }

        #endregion

        private CRichTextbox cRichTextbox1;
    }
}