namespace Inventar_2._0
{
    partial class PrintForm
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
            this.caseIdBox = new System.Windows.Forms.TextBox();
            this.printCaseBtn = new System.Windows.Forms.Button();
            this.printLastCaseBtn = new System.Windows.Forms.Button();
            this.customTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printCustomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caseIdBox
            // 
            this.caseIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caseIdBox.Font = new System.Drawing.Font("Arial", 11F);
            this.caseIdBox.Location = new System.Drawing.Point(12, 12);
            this.caseIdBox.Name = "caseIdBox";
            this.caseIdBox.Size = new System.Drawing.Size(136, 17);
            this.caseIdBox.TabIndex = 0;
            // 
            // printCaseBtn
            // 
            this.printCaseBtn.AutoSize = true;
            this.printCaseBtn.FlatAppearance.BorderSize = 0;
            this.printCaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printCaseBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.printCaseBtn.Location = new System.Drawing.Point(163, 9);
            this.printCaseBtn.Name = "printCaseBtn";
            this.printCaseBtn.Size = new System.Drawing.Size(91, 23);
            this.printCaseBtn.TabIndex = 2;
            this.printCaseBtn.Text = "Print Case";
            this.printCaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.printCaseBtn.UseVisualStyleBackColor = true;
            this.printCaseBtn.Click += new System.EventHandler(this.printCaseBtn_Click);
            // 
            // printLastCaseBtn
            // 
            this.printLastCaseBtn.AutoSize = true;
            this.printLastCaseBtn.FlatAppearance.BorderSize = 0;
            this.printLastCaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printLastCaseBtn.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.printLastCaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.printLastCaseBtn.Location = new System.Drawing.Point(12, 42);
            this.printLastCaseBtn.Name = "printLastCaseBtn";
            this.printLastCaseBtn.Size = new System.Drawing.Size(259, 30);
            this.printLastCaseBtn.TabIndex = 3;
            this.printLastCaseBtn.Text = "Print Siste Case";
            this.printLastCaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.printLastCaseBtn.UseVisualStyleBackColor = true;
            this.printLastCaseBtn.Click += new System.EventHandler(this.printLastCaseBtn_Click);
            // 
            // customTextBox
            // 
            this.customTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox.Font = new System.Drawing.Font("Arial", 11F);
            this.customTextBox.Location = new System.Drawing.Point(6, 85);
            this.customTextBox.Multiline = true;
            this.customTextBox.Name = "customTextBox";
            this.customTextBox.Size = new System.Drawing.Size(136, 75);
            this.customTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 1);
            this.panel2.TabIndex = 5;
            // 
            // printCustomBtn
            // 
            this.printCustomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printCustomBtn.AutoSize = true;
            this.printCustomBtn.FlatAppearance.BorderSize = 0;
            this.printCustomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printCustomBtn.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.printCustomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.printCustomBtn.Location = new System.Drawing.Point(148, 85);
            this.printCustomBtn.Name = "printCustomBtn";
            this.printCustomBtn.Size = new System.Drawing.Size(126, 75);
            this.printCustomBtn.TabIndex = 3;
            this.printCustomBtn.Text = "Print Custom";
            this.printCustomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.printCustomBtn.UseVisualStyleBackColor = true;
            this.printCustomBtn.Click += new System.EventHandler(this.printCustomBtn_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(279, 165);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customTextBox);
            this.Controls.Add(this.printCustomBtn);
            this.Controls.Add(this.printLastCaseBtn);
            this.Controls.Add(this.printCaseBtn);
            this.Controls.Add(this.caseIdBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caseIdBox;
        private System.Windows.Forms.Button printCaseBtn;
        private System.Windows.Forms.Button printLastCaseBtn;
        private System.Windows.Forms.TextBox customTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button printCustomBtn;
    }
}