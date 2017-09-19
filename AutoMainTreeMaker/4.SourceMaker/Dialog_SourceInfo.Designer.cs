namespace AutoMainTreeMaker.SourceMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_SourceInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.richStruct = new AutoMainTreeMaker.CRichTextbox();
            this.richMainTree = new AutoMainTreeMaker.CRichTextbox();
            this.name = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "struct(only variable)";
            // 
            // richStruct
            // 
            this.richStruct.IsChanged = false;
            this.richStruct.IsDrawingLine = false;
            this.richStruct.IsEditMode = true;
            this.richStruct.IsNumeric = false;
            this.richStruct.Location = new System.Drawing.Point(12, 43);
            this.richStruct.Name = "richStruct";
            this.richStruct.Size = new System.Drawing.Size(578, 481);
            this.richStruct.TabIndex = 5;
            this.richStruct.Text = "";
            // 
            // richMainTree
            // 
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsEditMode = true;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(596, 43);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.Size = new System.Drawing.Size(578, 481);
            this.richMainTree.TabIndex = 7;
            this.richMainTree.Text = resources.GetString("richMainTree.Text");
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(828, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 12);
            this.name.TabIndex = 6;
            this.name.Text = "MainTree(only LeafNode)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 8;
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
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(497, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(202, 66);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "소스 생성하기";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Dialog_SourceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 626);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.richMainTree);
            this.Controls.Add(this.name);
            this.Controls.Add(this.richStruct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dialog_SourceInfo";
            this.Text = "Dialog_SourceInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CRichTextbox richStruct;
        private CRichTextbox richMainTree;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
    }
}