namespace ExpenseManager.Forms
{
    partial class DataBaseDetailsForm
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
            this.PortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UidTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UIdLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.PortNumericUpDown);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.UidTextBox);
            this.MainPanel.Controls.Add(this.SubmitButton);
            this.MainPanel.Controls.Add(this.ColorPanel);
            this.MainPanel.Controls.Add(this.CreateButton);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.UIdLabel);
            this.MainPanel.Controls.Add(this.PortLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(358, 315);
            this.MainPanel.TabIndex = 2;
            // 
            // PortNumericUpDown
            // 
            this.PortNumericUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortNumericUpDown.Location = new System.Drawing.Point(129, 81);
            this.PortNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PortNumericUpDown.Name = "PortNumericUpDown";
            this.PortNumericUpDown.Size = new System.Drawing.Size(165, 24);
            this.PortNumericUpDown.TabIndex = 14;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(129, 181);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(165, 24);
            this.PasswordTextBox.TabIndex = 13;
            // 
            // UidTextBox
            // 
            this.UidTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UidTextBox.Location = new System.Drawing.Point(129, 132);
            this.UidTextBox.Name = "UidTextBox";
            this.UidTextBox.Size = new System.Drawing.Size(165, 24);
            this.UidTextBox.TabIndex = 12;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(136, 251);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(87, 34);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(358, 60);
            this.ColorPanel.TabIndex = 9;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(153, 317);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(87, 34);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 181);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(99, 29);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // UIdLabel
            // 
            this.UIdLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIdLabel.Location = new System.Drawing.Point(25, 132);
            this.UIdLabel.Name = "UIdLabel";
            this.UIdLabel.Size = new System.Drawing.Size(86, 29);
            this.UIdLabel.TabIndex = 2;
            this.UIdLabel.Text = "UId:";
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(25, 81);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(86, 29);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port:";
            // 
            // DataBaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 315);
            this.Controls.Add(this.MainPanel);
            this.Name = "DataBaseDetailsForm";
            this.Text = "DataBaseDetailsForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UIdLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UidTextBox;
        private System.Windows.Forms.NumericUpDown PortNumericUpDown;
    }
}