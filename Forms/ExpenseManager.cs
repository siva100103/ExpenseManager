using ExpenseManager.Forms;
using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
using ExpenseManager.UserControls;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class ExpenseManager : Form
    {
        private DataTable ExpenseDataTable = new DataTable();
        private DataTable CategoryDataTable = new DataTable();
        private DataTable SortDataTable = new DataTable();
        private DataTable BudgetDataTable = new DataTable();

        public ExpenseManager()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EventSubscriber();
            ExpenseTableCreator();
            CategoryTableCreator();
            SortTableCreator();
            BudgetTableCreator();
        }

        #region Events

        private void EventSubscriber()
        {
            ExpenseManagerClass.ExpenseCreated += ExpenseCreated;
            ExpenseManagerClass.ExpenseUpdated += ExpenseUpdated;
            ExpenseManagerClass.ExpenseDeleted += ExpenseDeleted;

            ExpenseManagerClass.CategoryCreated += CategoryCreated;
            ExpenseManagerClass.CategoryUpdated += CategoryUpdated;
            ExpenseManagerClass.CategoryDeleted += CategoryDeleted;

            ExpenseManagerClass.BudgetCreated += BudgetCreated;
            ExpenseManagerClass.BudgetUpdated += BudgetUpdated;
            ExpenseManagerClass.BudgetDeleted += BudgetDeleted;

            ExpenseManagerClass.LimitExeceded += LimitExeceded;
            FromPicker.ValueChanged += RefreshButtonClick;
            ToPicker.ValueChanged += RefreshButtonClick;
            MonthComboBox.SelectedIndexChanged += RefreshButtonClick;
        }

        private void LimitExeceded(string Id)
        {
            string[] arr = Id.Split(',');
            MessageBox.Show($"Your Budget for {arr[0]}-{arr[1]} Has been Execeded.Watch The Expenses CareFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EventUnSubscriber()
        {
            ExpenseManagerClass.ExpenseCreated -= ExpenseCreated;
            ExpenseManagerClass.ExpenseUpdated -= ExpenseUpdated;
            ExpenseManagerClass.ExpenseDeleted -= ExpenseDeleted;
        }
        private void ExpenseCreated(string ExpenseId)
        {
            Expense expense = (ExpenseManagerClass.ReadExpense(ExpenseId)).Value;
            Category category = (ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId)).Value;
            ExpenseDataTable.Rows.Add(expense.ExpenseId, category.CategoryName, expense.ExpenseAmount, expense.ExpenseTime.ToString(), expense.ExpenseNotes);
        }
        private void ExpenseUpdated(string ExpenseId)
        {
            Expense expense = ExpenseManagerClass.ReadExpense(ExpenseId).Value;
            foreach (DataGridViewRow rows in ExpenseGrid.Rows)
            {
                string Id = rows.Cells[0].Value.ToString();
                if (Id == expense.ExpenseId)
                {
                    rows.Cells[1].Value = ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId).Value.CategoryName;
                    rows.Cells[2].Value = expense.ExpenseAmount;
                    rows.Cells[3].Value = expense.ExpenseTime;
                    rows.Cells[4].Value = expense.ExpenseNotes;
                    break;
                }
            }
        }
        private void ExpenseDeleted(string ExpenseId)
        {
            foreach (DataGridViewRow rows in ExpenseGrid.Rows)
            {
                string Id = rows.Cells[0].Value.ToString();
                if (Id == ExpenseId)
                {
                    ExpenseGrid.Rows.Remove(rows);
                    break;
                }
            }
        }
        private void CategoryCreated(string categoryId)
        {
            Category category = (ExpenseManagerClass.ReadCategory(categoryId)).Value;
            CategoryDataTable.Rows.Add(categoryId, category.CategoryName);
            CategoryGrid.Sort(CategoryGrid.Columns["Name"], ListSortDirection.Ascending);
        }
        private void CategoryUpdated(string categoryId)
        {
            //change Data in CategoryGridTable
            foreach (DataGridViewRow row in CategoryGrid.Rows)
            {
                string Id = row.Cells[0].Value.ToString();
                if (categoryId == Id)
                {
                    string name = ExpenseManagerClass.ReadCategory(categoryId).Value.CategoryName;
                    row.Cells[1].Value = name;
                    break;
                }
            }

            //Update Expense Table
            ExpenseTableDataSetter();
        }
        private void CategoryDeleted(string categoryId)
        {
            foreach (DataGridViewRow row in CategoryGrid.Rows)
            {
                string Id = row.Cells[0].Value.ToString();
                if (Id == categoryId)
                {
                    CategoryGrid.Rows.Remove(row);
                    break;
                }
            }
        }
        private void BudgetCreated(string budgetId)
        {
            Budget budget = ExpenseManagerClass.ReadBudget(budgetId).Value;
            BudgetDataTable.Rows.Add(budget.Month, budget.Year, budget.Amount);
        }
        private void BudgetUpdated(string categoryId)
        {
            foreach (DataGridViewRow row in BudgetGrid.Rows)
            {
                string Id = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString();
                if (categoryId == Id)
                {
                    Budget budget = ExpenseManagerClass.ReadBudget(Id).Value;
                    row.Cells[2].Value = budget.Amount;
                    break;
                }
            }
        }
        private void BudgetDeleted(string categoryId)
        {
            foreach (DataGridViewRow row in BudgetGrid.Rows)
            {
                string Id = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString();
                if (categoryId == Id)
                {
                    BudgetGrid.Rows.Remove(row);
                    break;
                }
            }
        }

        #endregion

        #region TabSwitching
        private Control SelectedPage = null;
        private void MouseEntering(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.Parent.BackColor = Color.AliceBlue;
            c.Cursor = Cursors.Hand;
        }

        private void MouseLeaving(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (SelectedPage == null || !c.Parent.Name.Equals(SelectedPage.Parent.Name))
            {
                c.Parent.BackColor = Color.Transparent;
                c.Cursor = Cursors.Default;
            }
        }

        private void MouseClicked(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c.Parent.Name.Equals("ExpensePanel")) TabControl.SelectedIndex = 0;
            else if (c.Parent.Name.Equals("CategoriesPanel")) TabControl.SelectedIndex = 1;
            else if (c.Parent.Name.Equals("SortPanel")) TabControl.SelectedIndex = 2;
            else if (c.Parent.Name.Equals("BudgetPanel")) TabControl.SelectedIndex = 3;

            if (SelectedPage != null && SelectedPage.Parent.Name != c.Parent.Name) SelectedPage.Parent.BackColor = Color.Transparent;
            SelectedPage = c;
        }

        private void MenuButtonClick(object sender, EventArgs e)
        {
            ContentPanel.Visible = !ContentPanel.Visible;
        }

        #endregion

        #region ExpensePage

        private void ExpenseTableCreator()
        {
            ExpenseDataTable.Columns.Add("Id", typeof(string));
            ExpenseDataTable.Columns.Add("Category", typeof(string));
            ExpenseDataTable.Columns.Add("Amount", typeof(int));
            ExpenseDataTable.Columns.Add("Time", typeof(string));
            ExpenseDataTable.Columns.Add("Notes", typeof(string));
            ExpenseGrid.DataSource = ExpenseDataTable;
            ExpenseGrid.Columns[0].Visible = false;
            ExpenseTableDataSetter();
        }
        private void ExpenseTableDataSetter()
        {
            ExpenseDataTable.Rows.Clear();

            foreach (Expense exp in ExpenseManagerClass.ReadAllExpenses().Values)
            {
                ExpenseManagerClass.AddExistingExpense(exp.ExpenseId, exp.ExpenseCategoryId, exp.ExpenseAmount, exp.ExpenseTime, exp.ExpenseNotes);
            }
            ExpenseGrid.CurrentCell.Selected = false;
        }
        private void CreateExpenseButtonClick(object sender, EventArgs e)
        {
            ExpenseCreateForm createForm = new ExpenseCreateForm();
            createForm.Show();
        }
        private void ExpenseUpdateButtonClick(object sender, EventArgs e)
        {
            if (ExpenseGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose The Expense First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Id = ExpenseGrid.Rows[ExpenseGrid.CurrentRow.Index].Cells[0].Value.ToString();
            ExpenseUpdateForm updateForm = new ExpenseUpdateForm(Id);
            updateForm.Show();
        }
        private void ExpenseDeleteButtonClick(object sender, EventArgs e)
        {

            if (ExpenseGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose The Expense First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Do You Really Want to Remove This Expense", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string Id = ExpenseGrid.Rows[ExpenseGrid.CurrentRow.Index].Cells[0].Value.ToString();
                BooleanMsg res = ExpenseManagerClass.DeleteExpense(Id);
                if (res.Result)
                {
                    MessageBox.Show("Expense Deleted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExpenseGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < ExpenseGrid.Rows.Count)
            {
                foreach (DataGridViewRow row in ExpenseGrid.Rows)
                {
                    row.Selected = false;
                }
                ExpenseGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region CategoryPage

        private void CategoryTableCreator()
        {
            CategoryDataTable.Columns.Add("Id", typeof(string));
            CategoryDataTable.Columns.Add("Name", typeof(string));
            CategoryGrid.DataSource = CategoryDataTable;
            CategoryTableDataSetter();
        }

        private void CategoryTableDataSetter()
        {
            CategoryDataTable.Rows.Clear();
            List<Category> categories = ExpenseManagerClass.ReadAllCategories().Values.ToList();
            foreach (Category cat in ExpenseManagerClass.ReadAllCategories().Values)
            {
                CategoryDataTable.Rows.Add(cat.CategoryId, cat.CategoryName);
            }
            CategoryGrid.CurrentCell.Selected = false;
        }

        private void CreateCategoryButtonClick(object sender, EventArgs e)
        {
            CategoryCreateForm addForm = new CategoryCreateForm();
            addForm.Show();
        }

        private void CategoryGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < CategoryGrid.Rows.Count)
            {
                CategoryGrid.Rows[e.RowIndex].Selected = true;
            }

        }

        private void CategoryUpdateButtonClick(object sender, EventArgs e)
        {
            if (CategoryGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose Category First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string categoryId = CategoryGrid.CurrentRow.Cells[0].Value.ToString();
            CategoryUpdateForm updateForm = new CategoryUpdateForm(categoryId);
            updateForm.Show();
        }

        private void CategoryDeleteButtonClick(object sender, EventArgs e)
        {
            if (CategoryGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose Category First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Do You Want to Delete This Category..??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string categoryId = CategoryGrid.CurrentRow.Cells[0].Value.ToString();
                BooleanMsg res = ExpenseManagerClass.DeleteCategory(categoryId);
                if (res.Result) MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region SortPage

        private void SortTableCreator()
        {
            SortDataTable.Columns.Add("Category", typeof(string));
            SortDataTable.Columns.Add("Amount", typeof(int));
            SortDataTable.Columns.Add("Time", typeof(string));
            SortDataTable.Columns.Add("Notes", typeof(string));
            SortGrid.DataSource = SortDataTable;

            MonthComboBox.SelectedIndex = 0;
            FromPicker.MinDate = new DateTime(2020, 1, 1);
            FromPicker.Value = new DateTime(2020, 1, 1);
            ToPicker.Value = DateTime.Now;
            ToPicker.MaxDate = DateTime.Now;
            SortPageComboBoxUpdater();
            SortTableDataSetter(ExpenseManagerClass.FirstExpenseDate(), ExpenseManagerClass.LastExpenseDate(), null);
        }
        private void SortTableDataSetter(DateTime FromDate, DateTime ToDate, string categoryId)
        {
            SortDataTable.Rows.Clear();
            SortPageComboBoxUpdater();
            List<Expense> expenses = ExpenseManagerClass.ReadExpenses(FromDate, ToDate, categoryId).Values.ToList();
            expenses.Sort((exp1, exp2) => exp2.ExpenseTime.CompareTo(exp1.ExpenseTime));
            double totalSpends = 0;
            foreach (Expense expense in expenses)
            {
                totalSpends += expense.ExpenseAmount;
                SortDataTable.Rows.Add(ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId).Value.CategoryName, expense.ExpenseAmount, expense.ExpenseTime, expense.ExpenseNotes);
            }
            AmountLabel.Text = totalSpends.ToString();
        }

        private void SortPageComboBoxUpdater()
        {
            List<Category> categories = ExpenseManagerClass.ReadAllCategories().Values.ToList();
            categories.Sort((cat1, cat2) => cat1.CategoryName.CompareTo(cat2.CategoryName));
            categories.ForEach((cat) =>
            {
                if (!MonthComboBox.Items.Contains(cat.CategoryName)) MonthComboBox.Items.Add(cat.CategoryName);
            });
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            DateTime FromTime = FromPicker.Value;
            DateTime ToTime = ToPicker.Value;
            string categoryName = MonthComboBox.SelectedItem.ToString();
            if (categoryName == "All") SortTableDataSetter(FromTime, ToTime, null);
            else
            {
                Category category = ExpenseManagerClass.ReadAllCategories().Values.ToList().Find((cat) => cat.CategoryName == categoryName);
                SortTableDataSetter(FromTime, ToTime, category.CategoryId);
            }
            FromPicker.MaxDate = ToPicker.Value;
            ToPicker.MinDate = FromPicker.Value;
        }


        #endregion

        #region BudgetPage
        private void BudgetTableCreator()
        {
            BudgetDataTable.Columns.Add("Month", typeof(string));
            BudgetDataTable.Columns.Add("Year", typeof(string));
            BudgetDataTable.Columns.Add("Amount", typeof(int));
            BudgetGrid.DataSource = BudgetDataTable;
            BudgetTableDataSetter();
        }

        private void BudgetTableDataSetter()
        {
            BudgetDataTable.Rows.Clear();

            foreach (Budget budget in ExpenseManagerClass.ReadAllBudgets().Values)
            {
                BudgetDataTable.Rows.Add(budget.Month, budget.Year, budget.Amount);
            }
            BudgetGrid.CurrentCell.Selected = false;
        }

        private void AddBudgetButtonClick(object sender, EventArgs e)
        {
            BudgetSetForm budgetSetForm = new BudgetSetForm();
            budgetSetForm.Show();
        }
        private void BudgetGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < BudgetGrid.Rows.Count)
            {
                BudgetGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DeleteBudgetButtonClick(object sender, EventArgs e)
        {
            if (BudgetGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose Budget First...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Do You Really Want To Delete This Budget", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string BudgetId = BudgetGrid.CurrentRow.Cells[0].Value.ToString() + "," + BudgetGrid.CurrentRow.Cells[1].Value.ToString();
                BooleanMsg res = ExpenseManagerClass.DeleteBudget(BudgetId);
                if (res.Result)
                {
                    MessageBox.Show("Budget Deleted SuccessFully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBudgetButtonClick(object sender, EventArgs e)
        {
            if (BudgetGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Choose Budget First...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string BudgetId = BudgetGrid.CurrentRow.Cells[0].Value.ToString() + "," + BudgetGrid.CurrentRow.Cells[1].Value.ToString();
            BudgetUpdateForm budgetUpdate = new BudgetUpdateForm(BudgetId);
            budgetUpdate.Show();
        }

        #endregion

    }
}
