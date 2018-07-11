using System.Windows.Forms;

namespace AutoMainTreeMaker
{
    partial class AutoEnumDianlog
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
            this.startingEnum = new System.Windows.Forms.TextBox();
            this.interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingEnum
            // 
            this.startingEnum.Location = new System.Drawing.Point(101, 22);
            this.startingEnum.Name = "startingEnum";
            this.startingEnum.Size = new System.Drawing.Size(100, 21);
            this.startingEnum.TabIndex = 0;
            this.startingEnum.TextChanged += new System.EventHandler(this.startingEnum_TextChanged);
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(101, 49);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(100, 21);
            this.interval.TabIndex = 1;
            this.interval.Text = "10";
            this.interval.TextChanged += new System.EventHandler(this.interval_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "starting enum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "interval";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(73, 85);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutoEnumDianlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 120);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.startingEnum);
            this.Name = "AutoEnumDianlog";
            this.Text = "Setting Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingEnum;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;

        public int StartingEnumValue
        {
            get
            {
                if (startingEnum.Text.Length == 0)
                    return 0;
                else
                    return int.Parse(startingEnum.Text);
            }

        }

        public int IntervalValue
        {
            get
            {
                return int.Parse(interval.Text);
            }

        
        }
    }
}