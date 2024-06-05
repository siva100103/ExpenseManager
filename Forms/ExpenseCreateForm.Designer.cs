namespace ExpenseManager.Forms
{
    partial class ExpenseCreateForm
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
            ColorPanel = new System.Windows.Forms.Panel();
            CreateButton = new System.Windows.Forms.Button();
            NotesTextBox = new System.Windows.Forms.RichTextBox();
            NotesLabel = new System.Windows.Forms.Label();
            DateTimePicker = new System.Windows.Forms.DateTimePicker();
            TimeLabel = new System.Windows.Forms.Label();
            AmountSelector = new System.Windows.Forms.NumericUpDown();
            AmountLabel = new System.Windows.Forms.Label();
            CategoryBox = new System.Windows.Forms.ComboBox();
            CategoryLabel = new System.Windows.Forms.Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountSelector).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = System.Drawing.Color.White;
            MainPanel.Controls.Add(ColorPanel);
            MainPanel.Controls.Add(CreateButton);
            MainPanel.Controls.Add(NotesTextBox);
            MainPanel.Controls.Add(NotesLabel);
            MainPanel.Controls.Add(DateTimePicker);
            MainPanel.Controls.Add(TimeLabel);
            MainPanel.Controls.Add(AmountSelector);
            MainPanel.Controls.Add(AmountLabel);
            MainPanel.Controls.Add(CategoryBox);
            MainPanel.Controls.Add(CategoryLabel);
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 0);
            MainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new System.Drawing.Size(438, 437);
            MainPanel.TabIndex = 1;
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            ColorPanel.Location = new System.Drawing.Point(0, 0);
            ColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new System.Drawing.Size(438, 69);
            ColorPanel.TabIndex = 9;
            // 
            // CreateButton
            // 
            CreateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CreateButton.Location = new System.Drawing.Point(159, 347);
            CreateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new System.Drawing.Size(102, 39);
            CreateButton.TabIndex = 8;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButtonClick;
            // 
            // NotesTextBox
            // 
            NotesTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NotesTextBox.Location = new System.Drawing.Point(159, 271);
            NotesTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new System.Drawing.Size(208, 33);
            NotesTextBox.TabIndex = 7;
            NotesTextBox.Text = "";
            // 
            // NotesLabel
            // 
            NotesLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NotesLabel.Location = new System.Drawing.Point(29, 271);
            NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new System.Drawing.Size(88, 33);
            NotesLabel.TabIndex = 6;
            NotesLabel.Text = "Notes:";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DateTimePicker.Location = new System.Drawing.Point(159, 215);
            DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new System.Drawing.Size(208, 24);
            DateTimePicker.TabIndex = 5;
            // 
            // TimeLabel
            // 
            TimeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            TimeLabel.Location = new System.Drawing.Point(29, 215);
            TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(100, 33);
            TimeLabel.TabIndex = 4;
            TimeLabel.Text = "Time:";
            // 
            // AmountSelector
            // 
            AmountSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AmountSelector.Location = new System.Drawing.Point(159, 160);
            AmountSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AmountSelector.Maximum = new decimal(new int[] { 300000, 0, 0, 0 });
            AmountSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountSelector.Name = "AmountSelector";
            AmountSelector.Size = new System.Drawing.Size(209, 24);
            AmountSelector.TabIndex = 3;
            AmountSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AmountLabel
            // 
            AmountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AmountLabel.Location = new System.Drawing.Point(29, 160);
            AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(100, 33);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "Amount:";
            // 
            // CategoryBox
            // 
            CategoryBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Location = new System.Drawing.Point(159, 93);
            CategoryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new System.Drawing.Size(208, 24);
            CategoryBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CategoryLabel.Location = new System.Drawing.Point(29, 93);
            CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new System.Drawing.Size(100, 33);
            CategoryLabel.TabIndex = 0;
            CategoryLabel.Text = "Category:";
            // 
            // ExpenseCreateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 437);
            Controls.Add(MainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ExpenseCreateForm";
            Text = "ExpenseAddForm";
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AmountSelector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.NumericUpDown AmountSelector;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label CategoryLabel;
    }
}