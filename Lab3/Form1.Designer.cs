namespace Lab3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowTipLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.middleTipLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.highTipLbl = new System.Windows.Forms.Label();
            this.calculateTipBtn = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price of meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "15%";
            // 
            // lowTipLbl
            // 
            this.lowTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTipLbl.Location = new System.Drawing.Point(169, 42);
            this.lowTipLbl.Name = "lowTipLbl";
            this.lowTipLbl.Size = new System.Drawing.Size(100, 23);
            this.lowTipLbl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "18%";
            // 
            // middleTipLbl
            // 
            this.middleTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleTipLbl.Location = new System.Drawing.Point(169, 73);
            this.middleTipLbl.Name = "middleTipLbl";
            this.middleTipLbl.Size = new System.Drawing.Size(100, 23);
            this.middleTipLbl.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "20%";
            // 
            // highTipLbl
            // 
            this.highTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTipLbl.Location = new System.Drawing.Point(169, 102);
            this.highTipLbl.Name = "highTipLbl";
            this.highTipLbl.Size = new System.Drawing.Size(100, 23);
            this.highTipLbl.TabIndex = 6;
            // 
            // calculateTipBtn
            // 
            this.calculateTipBtn.Location = new System.Drawing.Point(91, 157);
            this.calculateTipBtn.Name = "calculateTipBtn";
            this.calculateTipBtn.Size = new System.Drawing.Size(94, 23);
            this.calculateTipBtn.TabIndex = 7;
            this.calculateTipBtn.Text = "Calculate Tip";
            this.calculateTipBtn.UseVisualStyleBackColor = true;
            this.calculateTipBtn.Click += new System.EventHandler(this.calculateTipBtn_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(169, 12);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 215);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.calculateTipBtn);
            this.Controls.Add(this.highTipLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middleTipLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lowTipLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lowTipLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label middleTipLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label highTipLbl;
        private System.Windows.Forms.Button calculateTipBtn;
        private System.Windows.Forms.TextBox priceTxt;
    }
}

