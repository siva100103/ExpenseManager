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
            MainPanel = new System.Windows.Forms.Panel();
            SubmitButton = new System.Windows.Forms.Button();
            AmountBox = new System.Windows.Forms.NumericUpDown();
            YearBox = new System.Windows.Forms.ComboBox();
            MonthBox = new System.Windows.Forms.ComboBox();
            AmountLabel = new System.Windows.Forms.Label();
            YearLabel = new System.Windows.Forms.Label();
            MonthLabel = new System.Windows.Forms.Label();
            ColorPanel = new System.Windows.Forms.Panel();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountBox).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = System.Drawing.Color.White;
            MainPanel.Controls.Add(SubmitButton);
            MainPanel.Controls.Add(AmountBox);
            MainPanel.Controls.Add(YearBox);
            MainPanel.Controls.Add(MonthBox);
            MainPanel.Controls.Add(AmountLabel);
            MainPanel.Controls.Add(YearLabel);
            MainPanel.Controls.Add(MonthLabel);
            MainPanel.Controls.Add(ColorPanel);
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 0);
            MainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new System.Drawing.Size(356, 365);
            MainPanel.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SubmitButton.Location = new System.Drawing.Point(138, 306);
            SubmitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new System.Drawing.Size(88, 32);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // AmountBox
            // 
            AmountBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AmountBox.Location = new System.Drawing.Point(138, 237);
            AmountBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AmountBox.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new System.Drawing.Size(170, 24);
            AmountBox.TabIndex = 6;
            // 
            // YearBox
            // 
            YearBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            YearBox.FormattingEnabled = true;
            YearBox.Location = new System.Drawing.Point(138, 179);
            YearBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            YearBox.Name = "YearBox";
            YearBox.Size = new System.Drawing.Size(170, 24);
            YearBox.TabIndex = 5;
            // 
            // MonthBox
            // 
            MonthBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MonthBox.FormattingEnabled = true;
            MonthBox.Location = new System.Drawing.Point(138, 112);
            MonthBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MonthBox.Name = "MonthBox";
            MonthBox.Size = new System.Drawing.Size(170, 24);
            MonthBox.TabIndex = 4;
            // 
            // AmountLabel
            // 
            AmountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AmountLabel.Location = new System.Drawing.Point(14, 237);
            AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(117, 27);
            AmountLabel.TabIndex = 3;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            YearLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            YearLabel.Location = new System.Drawing.Point(14, 177);
            YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new System.Drawing.Size(117, 27);
            YearLabel.TabIndex = 2;
            YearLabel.Text = "Year:";
            YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthLabel
            // 
            MonthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            MonthLabel.Location = new System.Drawing.Point(14, 112);
            MonthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new System.Drawing.Size(117, 27);
            MonthLabel.TabIndex = 1;
            MonthLabel.Text = "Month:";
            MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = System.Drawing.Color.Cyan;
            ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            ColorPanel.Location = new System.Drawing.Point(0, 0);
            ColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new System.Drawing.Size(356, 68);
            ColorPanel.TabIndex = 0;
            // 
            // BudgetSetForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(356, 365);
            Controls.Add(MainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "BudgetSetForm";
            Text = "BudgetSetForm";
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AmountBox).EndInit();
            ResumeLayout(false);
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