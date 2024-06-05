namespace ExpenseManager.Forms
{
    partial class CategoryCreateForm
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
            NameTextBox = new System.Windows.Forms.TextBox();
            ColorPanel = new System.Windows.Forms.Panel();
            AddButton = new System.Windows.Forms.Button();
            NameLabel = new System.Windows.Forms.Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = System.Drawing.Color.White;
            MainPanel.Controls.Add(NameTextBox);
            MainPanel.Controls.Add(ColorPanel);
            MainPanel.Controls.Add(AddButton);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 0);
            MainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new System.Drawing.Size(404, 275);
            MainPanel.TabIndex = 2;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NameTextBox.Location = new System.Drawing.Point(152, 108);
            NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(158, 24);
            NameTextBox.TabIndex = 10;
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            ColorPanel.Location = new System.Drawing.Point(0, 0);
            ColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new System.Drawing.Size(404, 69);
            ColorPanel.TabIndex = 9;
            // 
            // AddButton
            // 
            AddButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AddButton.Location = new System.Drawing.Point(136, 193);
            AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(102, 39);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButtonClick;
            // 
            // NameLabel
            // 
            NameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NameLabel.Location = new System.Drawing.Point(29, 93);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(100, 51);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryCreateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(404, 275);
            Controls.Add(MainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CategoryCreateForm";
            Text = "CategoryCreateForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}