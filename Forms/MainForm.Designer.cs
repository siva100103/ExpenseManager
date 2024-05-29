namespace ExpenseManager
{
    partial class MainForm
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
            System.Windows.Forms.PictureBox BudgetPictureBox;
            System.Windows.Forms.PictureBox SortPictureBox;
            System.Windows.Forms.PictureBox CategoryPictureBox;
            System.Windows.Forms.PictureBox ExpensePictureBox;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ExpensePage = new System.Windows.Forms.TabPage();
            this.ExpenseGrid = new System.Windows.Forms.DataGridView();
            this.AddExpensPanel = new System.Windows.Forms.Panel();
            this.CreateExpenseButton = new System.Windows.Forms.Button();
            this.CategoriesPage = new System.Windows.Forms.TabPage();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
            this.AddCategoryPanel = new System.Windows.Forms.Panel();
            this.CreateCategoryButton = new System.Windows.Forms.Button();
            this.SortPage = new System.Windows.Forms.TabPage();
            this.SortGrid = new System.Windows.Forms.DataGridView();
            this.TimePickerLabel = new System.Windows.Forms.Panel();
            this.ToPicker = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromPicker = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.BudgetPage = new System.Windows.Forms.TabPage();
            this.BudgetGrid = new System.Windows.Forms.DataGridView();
            this.AddBudgetPanel = new System.Windows.Forms.Panel();
            this.AddCustomBudgetButton = new System.Windows.Forms.Button();
            this.AddBudgetButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.BudgetPanel = new System.Windows.Forms.Panel();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortLabel = new System.Windows.Forms.Label();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.ExpensePanel = new System.Windows.Forms.Panel();
            this.ExpenseLabel = new System.Windows.Forms.Label();
            this.TopPictureBox = new System.Windows.Forms.PictureBox();
            BudgetPictureBox = new System.Windows.Forms.PictureBox();
            SortPictureBox = new System.Windows.Forms.PictureBox();
            CategoryPictureBox = new System.Windows.Forms.PictureBox();
            ExpensePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(BudgetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SortPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(CategoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ExpensePictureBox)).BeginInit();
            this.BodyPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ExpensePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).BeginInit();
            this.AddExpensPanel.SuspendLayout();
            this.CategoriesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
            this.AddCategoryPanel.SuspendLayout();
            this.SortPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortGrid)).BeginInit();
            this.TimePickerLabel.SuspendLayout();
            this.BudgetPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetGrid)).BeginInit();
            this.AddBudgetPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.BudgetPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            this.CategoriesPanel.SuspendLayout();
            this.ExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BudgetPictureBox
            // 
            BudgetPictureBox.BackColor = System.Drawing.Color.Transparent;
            BudgetPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            BudgetPictureBox.Image = global::ExpenseManager.Properties.Resources.icons8_budget_25;
            BudgetPictureBox.Location = new System.Drawing.Point(0, 0);
            BudgetPictureBox.Name = "BudgetPictureBox";
            BudgetPictureBox.Size = new System.Drawing.Size(54, 58);
            BudgetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BudgetPictureBox.TabIndex = 3;
            BudgetPictureBox.TabStop = false;
            BudgetPictureBox.Click += new System.EventHandler(this.MouseClicked);
            BudgetPictureBox.MouseEnter += new System.EventHandler(this.MouseEntering);
            BudgetPictureBox.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // SortPictureBox
            // 
            SortPictureBox.BackColor = System.Drawing.Color.Transparent;
            SortPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            SortPictureBox.Image = global::ExpenseManager.Properties.Resources.icons8_filter_25;
            SortPictureBox.Location = new System.Drawing.Point(0, 0);
            SortPictureBox.Name = "SortPictureBox";
            SortPictureBox.Size = new System.Drawing.Size(54, 58);
            SortPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            SortPictureBox.TabIndex = 3;
            SortPictureBox.TabStop = false;
            SortPictureBox.Click += new System.EventHandler(this.MouseClicked);
            SortPictureBox.MouseEnter += new System.EventHandler(this.MouseEntering);
            SortPictureBox.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // CategoryPictureBox
            // 
            CategoryPictureBox.BackColor = System.Drawing.Color.Transparent;
            CategoryPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            CategoryPictureBox.Image = global::ExpenseManager.Properties.Resources.icons8_category_25;
            CategoryPictureBox.Location = new System.Drawing.Point(0, 0);
            CategoryPictureBox.Name = "CategoryPictureBox";
            CategoryPictureBox.Size = new System.Drawing.Size(54, 58);
            CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            CategoryPictureBox.TabIndex = 3;
            CategoryPictureBox.TabStop = false;
            CategoryPictureBox.Click += new System.EventHandler(this.MouseClicked);
            CategoryPictureBox.MouseEnter += new System.EventHandler(this.MouseEntering);
            CategoryPictureBox.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // ExpensePictureBox
            // 
            ExpensePictureBox.BackColor = System.Drawing.Color.Transparent;
            ExpensePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            ExpensePictureBox.Image = global::ExpenseManager.Properties.Resources.icons8_expense_48;
            ExpensePictureBox.Location = new System.Drawing.Point(0, 0);
            ExpensePictureBox.Name = "ExpensePictureBox";
            ExpensePictureBox.Size = new System.Drawing.Size(54, 58);
            ExpensePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ExpensePictureBox.TabIndex = 3;
            ExpensePictureBox.TabStop = false;
            ExpensePictureBox.Click += new System.EventHandler(this.MouseClicked);
            ExpensePictureBox.MouseEnter += new System.EventHandler(this.MouseEntering);
            ExpensePictureBox.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.Transparent;
            this.BodyPanel.Controls.Add(this.TabControl);
            this.BodyPanel.Controls.Add(this.HeaderPanel);
            this.BodyPanel.Controls.Add(this.ContentPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CategoriesPage);
            this.TabControl.Controls.Add(this.ExpensePage);
            this.TabControl.Controls.Add(this.SortPage);
            this.TabControl.Controls.Add(this.BudgetPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(163, 62);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(637, 388);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 3;
            // 
            // ExpensePage
            // 
            this.ExpensePage.Controls.Add(this.ExpenseGrid);
            this.ExpensePage.Controls.Add(this.AddExpensPanel);
            this.ExpensePage.Location = new System.Drawing.Point(4, 5);
            this.ExpensePage.Name = "ExpensePage";
            this.ExpensePage.Padding = new System.Windows.Forms.Padding(3);
            this.ExpensePage.Size = new System.Drawing.Size(629, 379);
            this.ExpensePage.TabIndex = 0;
            this.ExpensePage.Text = "tabPage1";
            this.ExpensePage.UseVisualStyleBackColor = true;
            // 
            // ExpenseGrid
            // 
            this.ExpenseGrid.AllowUserToAddRows = false;
            this.ExpenseGrid.AllowUserToDeleteRows = false;
            this.ExpenseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ExpenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpenseGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExpenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseGrid.Location = new System.Drawing.Point(3, 44);
            this.ExpenseGrid.Name = "ExpenseGrid";
            this.ExpenseGrid.ReadOnly = true;
            this.ExpenseGrid.Size = new System.Drawing.Size(623, 332);
            this.ExpenseGrid.TabIndex = 1;
            this.ExpenseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseGridCellClick);
            // 
            // AddExpensPanel
            // 
            this.AddExpensPanel.Controls.Add(this.CreateExpenseButton);
            this.AddExpensPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddExpensPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddExpensPanel.Location = new System.Drawing.Point(3, 3);
            this.AddExpensPanel.Name = "AddExpensPanel";
            this.AddExpensPanel.Size = new System.Drawing.Size(623, 41);
            this.AddExpensPanel.TabIndex = 0;
            // 
            // CreateExpenseButton
            // 
            this.CreateExpenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateExpenseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateExpenseButton.Location = new System.Drawing.Point(505, 0);
            this.CreateExpenseButton.Name = "CreateExpenseButton";
            this.CreateExpenseButton.Size = new System.Drawing.Size(118, 41);
            this.CreateExpenseButton.TabIndex = 0;
            this.CreateExpenseButton.Text = "CreateExpense";
            this.CreateExpenseButton.UseVisualStyleBackColor = false;
            this.CreateExpenseButton.Click += new System.EventHandler(this.CreateExpenseButtonClick);
            // 
            // CategoriesPage
            // 
            this.CategoriesPage.Controls.Add(this.CategoryGrid);
            this.CategoriesPage.Controls.Add(this.AddCategoryPanel);
            this.CategoriesPage.Location = new System.Drawing.Point(4, 5);
            this.CategoriesPage.Name = "CategoriesPage";
            this.CategoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.CategoriesPage.Size = new System.Drawing.Size(629, 379);
            this.CategoriesPage.TabIndex = 1;
            this.CategoriesPage.Text = "tabPage2";
            this.CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.AllowUserToAddRows = false;
            this.CategoryGrid.AllowUserToDeleteRows = false;
            this.CategoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGrid.Location = new System.Drawing.Point(3, 43);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.ReadOnly = true;
            this.CategoryGrid.Size = new System.Drawing.Size(623, 333);
            this.CategoryGrid.TabIndex = 2;
            // 
            // AddCategoryPanel
            // 
            this.AddCategoryPanel.Controls.Add(this.CreateCategoryButton);
            this.AddCategoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCategoryPanel.Location = new System.Drawing.Point(3, 3);
            this.AddCategoryPanel.Name = "AddCategoryPanel";
            this.AddCategoryPanel.Size = new System.Drawing.Size(623, 40);
            this.AddCategoryPanel.TabIndex = 1;
            // 
            // CreateCategoryButton
            // 
            this.CreateCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateCategoryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCategoryButton.Location = new System.Drawing.Point(508, 0);
            this.CreateCategoryButton.Name = "CreateCategoryButton";
            this.CreateCategoryButton.Size = new System.Drawing.Size(115, 40);
            this.CreateCategoryButton.TabIndex = 0;
            this.CreateCategoryButton.Text = "CreateCategory";
            this.CreateCategoryButton.UseVisualStyleBackColor = false;
            this.CreateCategoryButton.Click += new System.EventHandler(this.CreateCategoryButtonClick);
            // 
            // SortPage
            // 
            this.SortPage.Controls.Add(this.SortGrid);
            this.SortPage.Controls.Add(this.TimePickerLabel);
            this.SortPage.Location = new System.Drawing.Point(4, 5);
            this.SortPage.Name = "SortPage";
            this.SortPage.Size = new System.Drawing.Size(629, 379);
            this.SortPage.TabIndex = 2;
            this.SortPage.Text = "tabPage3";
            this.SortPage.UseVisualStyleBackColor = true;
            // 
            // SortGrid
            // 
            this.SortGrid.AllowUserToAddRows = false;
            this.SortGrid.AllowUserToDeleteRows = false;
            this.SortGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SortGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SortGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SortGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SortGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.SortGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortGrid.Location = new System.Drawing.Point(0, 59);
            this.SortGrid.Name = "SortGrid";
            this.SortGrid.ReadOnly = true;
            this.SortGrid.Size = new System.Drawing.Size(629, 320);
            this.SortGrid.TabIndex = 3;
            // 
            // TimePickerLabel
            // 
            this.TimePickerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimePickerLabel.Controls.Add(this.ToPicker);
            this.TimePickerLabel.Controls.Add(this.ToLabel);
            this.TimePickerLabel.Controls.Add(this.FromPicker);
            this.TimePickerLabel.Controls.Add(this.FromLabel);
            this.TimePickerLabel.Controls.Add(this.MonthComboBox);
            this.TimePickerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimePickerLabel.Location = new System.Drawing.Point(0, 0);
            this.TimePickerLabel.Name = "TimePickerLabel";
            this.TimePickerLabel.Size = new System.Drawing.Size(629, 59);
            this.TimePickerLabel.TabIndex = 0;
            // 
            // ToPicker
            // 
            this.ToPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPicker.Location = new System.Drawing.Point(307, 24);
            this.ToPicker.Name = "ToPicker";
            this.ToPicker.Size = new System.Drawing.Size(145, 20);
            this.ToPicker.TabIndex = 4;
            this.ToPicker.Value = new System.DateTime(2024, 2, 28, 0, 0, 0, 0);
            // 
            // ToLabel
            // 
            this.ToLabel.BackColor = System.Drawing.Color.White;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(237, 24);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(55, 20);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To:";
            this.ToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromPicker
            // 
            this.FromPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromPicker.Location = new System.Drawing.Point(77, 24);
            this.FromPicker.Name = "FromPicker";
            this.FromPicker.Size = new System.Drawing.Size(145, 20);
            this.FromPicker.TabIndex = 2;
            this.FromPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // FromLabel
            // 
            this.FromLabel.BackColor = System.Drawing.Color.White;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(16, 23);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(55, 20);
            this.FromLabel.TabIndex = 1;
            this.FromLabel.Text = "From:";
            this.FromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "All"});
            this.MonthComboBox.Location = new System.Drawing.Point(508, 0);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(121, 24);
            this.MonthComboBox.TabIndex = 0;
            // 
            // BudgetPage
            // 
            this.BudgetPage.Controls.Add(this.BudgetGrid);
            this.BudgetPage.Controls.Add(this.AddBudgetPanel);
            this.BudgetPage.Location = new System.Drawing.Point(4, 5);
            this.BudgetPage.Name = "BudgetPage";
            this.BudgetPage.Size = new System.Drawing.Size(629, 379);
            this.BudgetPage.TabIndex = 3;
            this.BudgetPage.Text = "tabPage1";
            this.BudgetPage.UseVisualStyleBackColor = true;
            // 
            // BudgetGrid
            // 
            this.BudgetGrid.AllowUserToAddRows = false;
            this.BudgetGrid.AllowUserToDeleteRows = false;
            this.BudgetGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BudgetGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BudgetGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BudgetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BudgetGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.BudgetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BudgetGrid.Location = new System.Drawing.Point(0, 27);
            this.BudgetGrid.Name = "BudgetGrid";
            this.BudgetGrid.Size = new System.Drawing.Size(629, 352);
            this.BudgetGrid.TabIndex = 2;
            // 
            // AddBudgetPanel
            // 
            this.AddBudgetPanel.Controls.Add(this.AddCustomBudgetButton);
            this.AddBudgetPanel.Controls.Add(this.AddBudgetButton);
            this.AddBudgetPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddBudgetPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBudgetPanel.Location = new System.Drawing.Point(0, 0);
            this.AddBudgetPanel.Name = "AddBudgetPanel";
            this.AddBudgetPanel.Size = new System.Drawing.Size(629, 27);
            this.AddBudgetPanel.TabIndex = 1;
            // 
            // AddCustomBudgetButton
            // 
            this.AddCustomBudgetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddCustomBudgetButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddCustomBudgetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomBudgetButton.Location = new System.Drawing.Point(58, 0);
            this.AddCustomBudgetButton.Name = "AddCustomBudgetButton";
            this.AddCustomBudgetButton.Size = new System.Drawing.Size(58, 27);
            this.AddCustomBudgetButton.TabIndex = 4;
            this.AddCustomBudgetButton.Text = "Custom";
            this.AddCustomBudgetButton.UseVisualStyleBackColor = false;
            // 
            // AddBudgetButton
            // 
            this.AddBudgetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddBudgetButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBudgetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBudgetButton.Location = new System.Drawing.Point(0, 0);
            this.AddBudgetButton.Name = "AddBudgetButton";
            this.AddBudgetButton.Size = new System.Drawing.Size(58, 27);
            this.AddBudgetButton.TabIndex = 0;
            this.AddBudgetButton.Text = "Add";
            this.AddBudgetButton.UseVisualStyleBackColor = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.Controls.Add(this.MenuButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(163, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(637, 62);
            this.HeaderPanel.TabIndex = 2;
            // 
            // MenuButton
            // 
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 62);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Controls.Add(this.BudgetPanel);
            this.ContentPanel.Controls.Add(this.SortPanel);
            this.ContentPanel.Controls.Add(this.CategoriesPanel);
            this.ContentPanel.Controls.Add(this.ExpensePanel);
            this.ContentPanel.Controls.Add(this.TopPictureBox);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(163, 450);
            this.ContentPanel.TabIndex = 1;
            // 
            // BudgetPanel
            // 
            this.BudgetPanel.Controls.Add(this.BudgetLabel);
            this.BudgetPanel.Controls.Add(BudgetPictureBox);
            this.BudgetPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BudgetPanel.Location = new System.Drawing.Point(0, 242);
            this.BudgetPanel.Name = "BudgetPanel";
            this.BudgetPanel.Size = new System.Drawing.Size(163, 58);
            this.BudgetPanel.TabIndex = 6;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.BackColor = System.Drawing.Color.Transparent;
            this.BudgetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLabel.Location = new System.Drawing.Point(54, 0);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(109, 58);
            this.BudgetLabel.TabIndex = 3;
            this.BudgetLabel.Text = "Budget";
            this.BudgetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BudgetLabel.Click += new System.EventHandler(this.MouseClicked);
            this.BudgetLabel.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.BudgetLabel.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // SortPanel
            // 
            this.SortPanel.Controls.Add(this.SortLabel);
            this.SortPanel.Controls.Add(SortPictureBox);
            this.SortPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortPanel.Location = new System.Drawing.Point(0, 184);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(163, 58);
            this.SortPanel.TabIndex = 5;
            // 
            // SortLabel
            // 
            this.SortLabel.BackColor = System.Drawing.Color.Transparent;
            this.SortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortLabel.Location = new System.Drawing.Point(54, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(109, 58);
            this.SortLabel.TabIndex = 3;
            this.SortLabel.Text = "Sort";
            this.SortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SortLabel.Click += new System.EventHandler(this.MouseClicked);
            this.SortLabel.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.SortLabel.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.Controls.Add(this.CategoriesLabel);
            this.CategoriesPanel.Controls.Add(CategoryPictureBox);
            this.CategoriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesPanel.Location = new System.Drawing.Point(0, 126);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(163, 58);
            this.CategoriesPanel.TabIndex = 4;
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.Location = new System.Drawing.Point(54, 0);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(109, 58);
            this.CategoriesLabel.TabIndex = 3;
            this.CategoriesLabel.Text = "Categories";
            this.CategoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CategoriesLabel.Click += new System.EventHandler(this.MouseClicked);
            this.CategoriesLabel.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.CategoriesLabel.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // ExpensePanel
            // 
            this.ExpensePanel.Controls.Add(this.ExpenseLabel);
            this.ExpensePanel.Controls.Add(ExpensePictureBox);
            this.ExpensePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpensePanel.Location = new System.Drawing.Point(0, 68);
            this.ExpensePanel.Name = "ExpensePanel";
            this.ExpensePanel.Size = new System.Drawing.Size(163, 58);
            this.ExpensePanel.TabIndex = 3;
            // 
            // ExpenseLabel
            // 
            this.ExpenseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseLabel.Location = new System.Drawing.Point(54, 0);
            this.ExpenseLabel.Name = "ExpenseLabel";
            this.ExpenseLabel.Size = new System.Drawing.Size(109, 58);
            this.ExpenseLabel.TabIndex = 3;
            this.ExpenseLabel.Text = "Expense";
            this.ExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExpenseLabel.Click += new System.EventHandler(this.MouseClicked);
            this.ExpenseLabel.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.ExpenseLabel.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // TopPictureBox
            // 
            this.TopPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPictureBox.Image = global::ExpenseManager.Properties.Resources.icons8_category_64;
            this.TopPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TopPictureBox.Name = "TopPictureBox";
            this.TopPictureBox.Size = new System.Drawing.Size(163, 68);
            this.TopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TopPictureBox.TabIndex = 3;
            this.TopPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(BudgetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SortPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(CategoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ExpensePictureBox)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ExpensePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).EndInit();
            this.AddExpensPanel.ResumeLayout(false);
            this.CategoriesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
            this.AddCategoryPanel.ResumeLayout(false);
            this.SortPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SortGrid)).EndInit();
            this.TimePickerLabel.ResumeLayout(false);
            this.BudgetPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetGrid)).EndInit();
            this.AddBudgetPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.BudgetPanel.ResumeLayout(false);
            this.SortPanel.ResumeLayout(false);
            this.CategoriesPanel.ResumeLayout(false);
            this.ExpensePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ExpensePage;
        private System.Windows.Forms.DataGridView ExpenseGrid;
        private System.Windows.Forms.Panel AddExpensPanel;
        private System.Windows.Forms.Button CreateExpenseButton;
        private System.Windows.Forms.TabPage CategoriesPage;
        private System.Windows.Forms.DataGridView CategoryGrid;
        private System.Windows.Forms.Panel AddCategoryPanel;
        private System.Windows.Forms.Button CreateCategoryButton;
        private System.Windows.Forms.TabPage SortPage;
        private System.Windows.Forms.DataGridView SortGrid;
        private System.Windows.Forms.Panel TimePickerLabel;
        private System.Windows.Forms.DateTimePicker ToPicker;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker FromPicker;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.TabPage BudgetPage;
        private System.Windows.Forms.DataGridView BudgetGrid;
        private System.Windows.Forms.Panel AddBudgetPanel;
        private System.Windows.Forms.Button AddCustomBudgetButton;
        private System.Windows.Forms.Button AddBudgetButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel BudgetPanel;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Panel ExpensePanel;
        private System.Windows.Forms.Label ExpenseLabel;
        private System.Windows.Forms.PictureBox TopPictureBox;
    }
}

