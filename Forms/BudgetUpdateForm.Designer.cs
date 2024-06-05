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
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthValueLabel = new System.Windows.Forms.Label();
            this.YearValueLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountValueBox = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(331, 60);
            this.ColorPanel.TabIndex = 10;
            // 
            // MonthLabel
            // 
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(12, 90);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(100, 23);
            this.MonthLabel.TabIndex = 11;
            this.MonthLabel.Text = "Month:";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(12, 141);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(100, 23);
            this.YearLabel.TabIndex = 12;
            this.YearLabel.Text = "Year:";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthValueLabel
            // 
            this.MonthValueLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthValueLabel.Location = new System.Drawing.Point(128, 90);
            this.MonthValueLabel.Name = "MonthValueLabel";
            this.MonthValueLabel.Size = new System.Drawing.Size(100, 23);
            this.MonthValueLabel.TabIndex = 13;
            this.MonthValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearValueLabel
            // 
            this.YearValueLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearValueLabel.Location = new System.Drawing.Point(118, 141);
            this.YearValueLabel.Name = "YearValueLabel";
            this.YearValueLabel.Size = new System.Drawing.Size(100, 23);
            this.YearValueLabel.TabIndex = 14;
            this.YearValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(12, 191);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(100, 23);
            this.AmountLabel.TabIndex = 15;
            this.AmountLabel.Text = "Amount";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountValueBox
            // 
            this.AmountValueBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountValueBox.Location = new System.Drawing.Point(132, 190);
            this.AmountValueBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AmountValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountValueBox.Name = "AmountValueBox";
            this.AmountValueBox.Size = new System.Drawing.Size(132, 24);
            this.AmountValueBox.TabIndex = 16;
            this.AmountValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(122, 259);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 31);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // BudgetUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 327);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AmountValueBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.YearValueLabel);
            this.Controls.Add(this.MonthValueLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.ColorPanel);
            this.Name = "BudgetUpdateForm";
            this.Text = "BudgetUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountValueBox)).EndInit();
            this.ResumeLayout(false);

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