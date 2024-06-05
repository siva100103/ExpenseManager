namespace ExpenseManager.Forms
{
    partial class BudgetUpdateForm
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
            ColorPanel = new System.Windows.Forms.Panel();
            MonthLabel = new System.Windows.Forms.Label();
            YearLabel = new System.Windows.Forms.Label();
            MonthValueLabel = new System.Windows.Forms.Label();
            YearValueLabel = new System.Windows.Forms.Label();
            AmountLabel = new System.Windows.Forms.Label();
            AmountValueBox = new System.Windows.Forms.NumericUpDown();
            SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)AmountValueBox).BeginInit();
            SuspendLayout();
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            ColorPanel.Location = new System.Drawing.Point(0, 0);
            ColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new System.Drawing.Size(386, 69);
            ColorPanel.TabIndex = 10;
            // 
            // MonthLabel
            // 
            MonthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            MonthLabel.Location = new System.Drawing.Point(14, 104);
            MonthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new System.Drawing.Size(117, 27);
            MonthLabel.TabIndex = 11;
            MonthLabel.Text = "Month:";
            MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            YearLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            YearLabel.Location = new System.Drawing.Point(14, 163);
            YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new System.Drawing.Size(117, 27);
            YearLabel.TabIndex = 12;
            YearLabel.Text = "Year:";
            YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthValueLabel
            // 
            MonthValueLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MonthValueLabel.Location = new System.Drawing.Point(149, 104);
            MonthValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MonthValueLabel.Name = "MonthValueLabel";
            MonthValueLabel.Size = new System.Drawing.Size(117, 27);
            MonthValueLabel.TabIndex = 13;
            MonthValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearValueLabel
            // 
            YearValueLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            YearValueLabel.Location = new System.Drawing.Point(138, 163);
            YearValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            YearValueLabel.Name = "YearValueLabel";
            YearValueLabel.Size = new System.Drawing.Size(117, 27);
            YearValueLabel.TabIndex = 14;
            YearValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            AmountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AmountLabel.Location = new System.Drawing.Point(14, 220);
            AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(117, 27);
            AmountLabel.TabIndex = 15;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountValueBox
            // 
            AmountValueBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AmountValueBox.Location = new System.Drawing.Point(154, 219);
            AmountValueBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AmountValueBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountValueBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountValueBox.Name = "AmountValueBox";
            AmountValueBox.Size = new System.Drawing.Size(154, 24);
            AmountValueBox.TabIndex = 16;
            AmountValueBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SubmitButton.Location = new System.Drawing.Point(154, 299);
            SubmitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new System.Drawing.Size(88, 36);
            SubmitButton.TabIndex = 17;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // BudgetUpdateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(386, 377);
            Controls.Add(SubmitButton);
            Controls.Add(AmountValueBox);
            Controls.Add(AmountLabel);
            Controls.Add(YearValueLabel);
            Controls.Add(MonthValueLabel);
            Controls.Add(YearLabel);
            Controls.Add(MonthLabel);
            Controls.Add(ColorPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "BudgetUpdateForm";
            Text = "BudgetUpdateForm";
            ((System.ComponentModel.ISupportInitialize)AmountValueBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthValueLabel;
        private System.Windows.Forms.Label YearValueLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.NumericUpDown AmountValueBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}