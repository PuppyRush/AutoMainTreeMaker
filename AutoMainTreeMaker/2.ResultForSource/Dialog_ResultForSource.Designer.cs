﻿namespace AutoMainTreeMaker.ResltForSource
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
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.richTextCommnt = new AutoMainTreeMaker.CRichTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richMainTree
            // 
            this.richMainTree.AcceptsTab = true;
            this.richMainTree.IsChanged = false;
            this.richMainTree.IsDrawingLine = false;
            this.richMainTree.IsEditMode = true;
            this.richMainTree.IsNumeric = false;
            this.richMainTree.Location = new System.Drawing.Point(12, 34);
            this.richMainTree.Name = "richMainTree";
            this.richMainTree.Size = new System.Drawing.Size(428, 396);
            this.richMainTree.TabIndex = 0;
            this.richMainTree.Text = "";
            this.richMainTree.WordWrap = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(451, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 41);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "다음 ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "메인트리";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(312, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- 이전";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richTextCommnt
            // 
            this.richTextCommnt.AcceptsTab = true;
            this.richTextCommnt.IsChanged = false;
            this.richTextCommnt.IsDrawingLine = false;
            this.richTextCommnt.IsEditMode = true;
            this.richTextCommnt.IsNumeric = false;
            this.richTextCommnt.Location = new System.Drawing.Point(451, 34);
            this.richTextCommnt.Name = "richTextCommnt";
            this.richTextCommnt.Size = new System.Drawing.Size(352, 396);
            this.richTextCommnt.TabIndex = 6;
            this.richTextCommnt.Text = "";
            this.richTextCommnt.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "주석";
            // 
            // Dialog_ResultForSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextCommnt);
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private CRichTextbox richTextCommnt;
        private System.Windows.Forms.Label label2;
    }
}