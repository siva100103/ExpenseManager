namespace ExpenseManager.Forms
{
    partial class BudgetSetForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.SubmitButton);
            this.MainPanel.Controls.Add(this.AmountBox);
            this.MainPanel.Controls.Add(this.YearBox);
            this.MainPanel.Controls.Add(this.MonthBox);
            this.MainPanel.Controls.Add(this.AmountLabel);
            this.MainPanel.Controls.Add(this.YearLabel);
            this.MainPanel.Controls.Add(this.MonthLabel);
            this.MainPanel.Controls.Add(this.ColorPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(305, 316);
            this.MainPanel.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(118, 266);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(118, 205);
            this.AmountBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(146, 20);
            this.AmountBox.TabIndex = 6;
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(118, 155);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(146, 24);
            this.YearBox.TabIndex = 5;
            // 
            // MonthBox
            // 
            this.MonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Location = new System.Drawing.Point(118, 97);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(146, 24);
            this.MonthBox.TabIndex = 4;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(12, 205);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(100, 23);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Amount";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(12, 153);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(100, 23);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Year:";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthLabel
            // 
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(12, 97);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(100, 23);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "Month:";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Cyan;
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(305, 59);
            this.ColorPanel.TabIndex = 0;
            // 
            // BudgetSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 316);
            this.Controls.Add(this.MainPanel);
            this.Name = "BudgetSetForm";
            this.Text = "BudgetSetForm";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.NumericUpDown AmountBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}