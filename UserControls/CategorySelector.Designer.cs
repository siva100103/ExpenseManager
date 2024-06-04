namespace ExpenseManager.UserControls
{
    partial class CategorySelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CheckBoxPanel = new System.Windows.Forms.Panel();
            this.ClosePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClosePanel
            // 
            this.ClosePanel.Controls.Add(this.CloseButton);
            this.ClosePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClosePanel.Location = new System.Drawing.Point(10, 10);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(169, 27);
            this.ClosePanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = global::ExpenseManager.Properties.Resources.icons8_close_15;
            this.CloseButton.Location = new System.Drawing.Point(134, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 27);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // CheckBoxPanel
            // 
            this.CheckBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxPanel.Location = new System.Drawing.Point(10, 37);
            this.CheckBoxPanel.Name = "CheckBoxPanel";
            this.CheckBoxPanel.Size = new System.Drawing.Size(169, 118);
            this.CheckBoxPanel.TabIndex = 1;
            this.CheckBoxPanel.Visible = false;
            // 
            // CategorySelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CheckBoxPanel);
            this.Controls.Add(this.ClosePanel);
            this.Name = "CategorySelector";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(189, 165);
            this.ClosePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel CheckBoxPanel;
        private System.Windows.Forms.Button CloseButton;
    }
}
