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
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.White;
            this.Mainpanel.Controls.Add(this.NameTextBox);
            this.Mainpanel.Controls.Add(this.ColorPanel);
            this.Mainpanel.Controls.Add(this.UpdateButton);
            this.Mainpanel.Controls.Add(this.NameLabel);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(346, 238);
            this.Mainpanel.TabIndex = 3;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(346, 60);
            this.ColorPanel.TabIndex = 9;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(117, 167);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 34);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(25, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 44);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(117, 93);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(153, 24);
            this.NameTextBox.TabIndex = 10;
            // 
            // CategoryUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 238);
            this.Controls.Add(this.Mainpanel);
            this.Name = "CategoryUpdateForm";
            this.Text = "CategoryUpdateForm";
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}