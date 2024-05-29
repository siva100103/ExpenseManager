namespace ExpenseManager.Forms
{
    partial class ExpenseUpdateForm
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
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.AmountSelector = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.ColorPanel);
            this.MainPanel.Controls.Add(this.UpdateButton);
            this.MainPanel.Controls.Add(this.NotesTextBox);
            this.MainPanel.Controls.Add(this.NotesLabel);
            this.MainPanel.Controls.Add(this.DateTimePicker);
            this.MainPanel.Controls.Add(this.TimeLabel);
            this.MainPanel.Controls.Add(this.AmountSelector);
            this.MainPanel.Controls.Add(this.AmountLabel);
            this.MainPanel.Controls.Add(this.CategoryBox);
            this.MainPanel.Controls.Add(this.CategoryLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(401, 379);
            this.MainPanel.TabIndex = 2;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(401, 60);
            this.ColorPanel.TabIndex = 9;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(153, 317);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 34);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(136, 235);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(158, 29);
            this.NotesTextBox.TabIndex = 7;
            this.NotesTextBox.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(25, 235);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(75, 29);
            this.NotesLabel.TabIndex = 6;
            this.NotesLabel.Text = "Notes:";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Location = new System.Drawing.Point(136, 186);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(158, 22);
            this.DateTimePicker.TabIndex = 5;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(25, 186);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(86, 29);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Time:";
            // 
            // AmountSelector
            // 
            this.AmountSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSelector.Location = new System.Drawing.Point(136, 139);
            this.AmountSelector.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.AmountSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountSelector.Name = "AmountSelector";
            this.AmountSelector.Size = new System.Drawing.Size(158, 22);
            this.AmountSelector.TabIndex = 3;
            this.AmountSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountLabel
            // 
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(25, 139);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(86, 29);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount:";
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(136, 81);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(158, 24);
            this.CategoryBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(25, 81);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(86, 29);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // ExpenseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 379);
            this.Controls.Add(this.MainPanel);
            this.Name = "ExpenseEditForm";
            this.Text = "ExpenseEditForm";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button UpdateButton;
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