namespace ExpenseManager.Forms
{
    partial class CategoryUpdateForm
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
            Mainpanel = new System.Windows.Forms.Panel();
            NameTextBox = new System.Windows.Forms.TextBox();
            ColorPanel = new System.Windows.Forms.Panel();
            UpdateButton = new System.Windows.Forms.Button();
            NameLabel = new System.Windows.Forms.Label();
            Mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Mainpanel
            // 
            Mainpanel.BackColor = System.Drawing.Color.White;
            Mainpanel.Controls.Add(NameTextBox);
            Mainpanel.Controls.Add(ColorPanel);
            Mainpanel.Controls.Add(UpdateButton);
            Mainpanel.Controls.Add(NameLabel);
            Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            Mainpanel.Location = new System.Drawing.Point(0, 0);
            Mainpanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new System.Drawing.Size(404, 275);
            Mainpanel.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NameTextBox.Location = new System.Drawing.Point(136, 107);
            NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(178, 24);
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
            // UpdateButton
            // 
            UpdateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UpdateButton.Location = new System.Drawing.Point(136, 191);
            UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(102, 39);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButtonClick;
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
            // CategoryUpdateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(404, 275);
            Controls.Add(Mainpanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CategoryUpdateForm";
            Text = "CategoryUpdateForm";
            Mainpanel.ResumeLayout(false);
            Mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}