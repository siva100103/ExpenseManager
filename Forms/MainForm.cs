using ExpenseManager.Forms;
using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
using GoLibrary;
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
    public partial class MainForm : Form
    {
        private DataTable ExpenseDataTable = new DataTable();
        private DataTable CategoryDataTable = new DataTable();
        private DataTable SortDataTable = new DataTable();

        public MainForm()
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

            FromPicker.ValueChanged += RefreshButtonClick;
            ToPicker.ValueChanged += RefreshButtonClick;
            MonthComboBox.SelectedIndexChanged += RefreshButtonClick;
        }

        private void EventUnSubscriber()
        {
            ExpenseManagerClass.ExpenseCreated -= ExpenseCreated;
            ExpenseManagerClass.ExpenseUpdated -= ExpenseUpdated;
            ExpenseManagerClass.ExpenseDeleted -= ExpenseDeleted;
        }

        private void ExpenseCreated(string ExpenseId)
        {
            Expense expense = ExpenseManagerClass.ReadExpense(ExpenseId);
            Category category = ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId);
            ExpenseDataTable.Rows.Add(expense.ExpenseId, category.CategoryName, expense.ExpenseAmount, expense.ExpenseTime.ToString(), expense.ExpenseNotes, Properties.Resources.icons8_edit_24, Properties.Resources.icons8_remove_25);
        }

        private void ExpenseUpdated(string ExpenseId)
        {
            Expense expense = ExpenseManagerClass.ReadExpense(ExpenseId);
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
            Category category = ExpenseManagerClass.ReadCategory(categoryId);
            CategoryDataTable.Rows.Add(categoryId, category.CategoryName, Properties.Resources.icons8_edit_24, Properties.Resources.icons8_remove_25);

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
                c.Parent.BackColor = Color.FromArgb(192, 255, 255);
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

            if (SelectedPage != null && SelectedPage.Parent.Name != c.Parent.Name) SelectedPage.Parent.BackColor = Color.FromArgb(192, 255, 255);
            SelectedPage = c;
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
            ExpenseDataTable.Columns.Add(" ", typeof(Image));
            ExpenseDataTable.Columns.Add("  ", typeof(Image));
            ExpenseGrid.DataSource = ExpenseDataTable;
            ExpenseTableDataSetter();
        }

        private void ExpenseTableDataSetter()
        {
            ExpenseDataTable.Rows.Clear();

            ExpenseManagerClass.ReadAllExpenses().Values.ToList().ForEach((exp) =>
            {
                Category category = ExpenseManagerClass.ReadCategory(exp.ExpenseCategoryId);
                ExpenseDataTable.Rows.Add(exp.ExpenseId, category.CategoryName, exp.ExpenseAmount, exp.ExpenseTime.ToString(), exp.ExpenseNotes, Properties.Resources.icons8_edit_24, Properties.Resources.icons8_remove_25);
            });
        }

        private void CreateExpenseButtonClick(object sender, EventArgs e)
        {
            ExpenseCreateForm createForm = new ExpenseCreateForm();
            createForm.Show();
        }

        private void ExpenseGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < ExpenseGrid.Rows.Count && e.ColumnIndex == 5)
            {
                string ExpenseId = ExpenseGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                ExpenseUpdateButtonClick(ExpenseId);
            }
            else if (e.RowIndex != -1 && e.RowIndex < ExpenseGrid.Rows.Count && e.ColumnIndex == 6)
            {
                string ExpenseId = ExpenseGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                ExpenseDeleteButtonClick(ExpenseId);
            }
        }

        private void ExpenseUpdateButtonClick(string Id)
        {
            ExpenseUpdateForm updateForm = new ExpenseUpdateForm(Id);
            updateForm.Show();
        }
       
        private void ExpenseDeleteButtonClick(string Id)
        {
            DialogResult result = MessageBox.Show("Do You Really Want to Remove This Expense","Confirmation" ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BooleanMsg res=ExpenseManagerClass.DeleteExpense(Id);
                if (res)
                {
                    MessageBox.Show("Expense Deleted Successfully!!!");
                }
                else
                {
                    MessageBox.Show(res.Message);
                }
            }
        }

        #endregion

        #region CategoryPage

        private void CategoryTableCreator()
        {
            CategoryDataTable.Columns.Add("Id", typeof(string));
            CategoryDataTable.Columns.Add("Name", typeof(string));
            CategoryDataTable.Columns.Add(" ", typeof(Image));
            CategoryDataTable.Columns.Add("  ", typeof(Image));
            CategoryGrid.DataSource = CategoryDataTable;
            CategoryTableDataSetter();
        }

        private void CategoryTableDataSetter()
        {
            CategoryDataTable.Rows.Clear();
            List<Category> categories = ExpenseManagerClass.GetAllCategories().Values.ToList();
            categories.Sort((cat1, cat2) => cat1.CategoryName.CompareTo(cat2.CategoryName));
            categories.ForEach((cat) =>
            {
                CategoryDataTable.Rows.Add(cat.CategoryId,cat.CategoryName,Properties.Resources.icons8_edit_24,Properties.Resources.icons8_remove_25);
            });
        }

        private void CreateCategoryButtonClick(object sender, EventArgs e)
        {
            CategoryCreateForm addForm = new CategoryCreateForm();
            addForm.Show();
        }

        private void CategoryGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < CategoryGrid.Rows.Count && e.ColumnIndex == 2)
            {
                string categoryId = CategoryGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                CategoryUpdateButtonClick(categoryId);
            }
            else if (e.RowIndex != -1 && e.RowIndex < CategoryGrid.Rows.Count && e.ColumnIndex == 3)
            {
                string categoryId = CategoryGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                CategoryDeleteButtonClick(categoryId);
            }
        }

        private void CategoryUpdateButtonClick(string categoryId)
        {
            CategoryUpdateForm updateForm = new CategoryUpdateForm(categoryId);
            updateForm.Show();
        }

        private void CategoryDeleteButtonClick(string categoryId)
        {
            DialogResult result = MessageBox.Show("Do You Want to Delete This Category..??", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BooleanMsg res=ExpenseManagerClass.DeleteCategory(categoryId);
                if (res) MessageBox.Show("Category Deleted Successfully");
                else MessageBox.Show(res.Message);
            }
        }

        #endregion

        #region SortPage

        private void SortTableCreator()
        {
            SortDataTable.Columns.Add("Id", typeof(string));
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
            foreach (Expense expense in expenses)
            {
                SortDataTable.Rows.Add(expense.ExpenseId, ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId).Value.CategoryName, expense.ExpenseAmount, expense.ExpenseTime, expense.ExpenseNotes);
            }
        }

        private void SortPageComboBoxUpdater()
        {
            List<Category> categories = ExpenseManagerClass.GetAllCategories().Values.ToList();
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
                Category category = ExpenseManagerClass.GetAllCategories().Values.ToList().Find((cat) => cat.CategoryName == categoryName);
                SortTableDataSetter(FromTime, ToTime, category.CategoryId);
            }
            FromPicker.MaxDate = ToPicker.Value;
            ToPicker.MinDate = FromPicker.Value;
        } 

        #endregion


    }
}
