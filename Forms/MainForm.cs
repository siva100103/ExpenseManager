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

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EventSubscriber();
            ExpenseTableCreator();
        }



        private void EventSubscriber()
        {
            ExpenseManagerClass.ExpenseCreated += ExpenseCreated;
            ExpenseManagerClass.ExpenseUpdated += ExpenseUpdated;
            ExpenseManagerClass.ExpenseDeleted += ExpenseDeleted;
        }

       

        private void EventUnSubscriber()
        {
            ExpenseManagerClass.ExpenseCreated -= ExpenseCreated;
            ExpenseManagerClass.ExpenseUpdated -= ExpenseUpdated;
            ExpenseManagerClass.ExpenseDeleted -= ExpenseDeleted;
        }

        
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

        #region Expenses
       
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

            ExpenseManagerClass.GetAllExpenses().Values.ToList().ForEach((exp) =>
            {
                Category category = ExpenseManagerClass.GetCategory(exp.ExpenseCategoryId);
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


        private void AddCategoryButtonClick(object sender, EventArgs e)
        {
            CategoryAddForm addForm = new CategoryAddForm();
            addForm.Show();
        }

        #region Events

        private void ExpenseCreated(Expense expense)
        {
            Category category = ExpenseManagerClass.GetCategory(expense.ExpenseCategoryId);
            ExpenseDataTable.Rows.Add(expense.ExpenseId, category.CategoryName, expense.ExpenseAmount, expense.ExpenseTime.ToString(), expense.ExpenseNotes, Properties.Resources.icons8_edit_24, Properties.Resources.icons8_remove_25);
        }

        private void ExpenseUpdated(Expense expense)
        {
            foreach (DataGridViewRow rows in ExpenseGrid.Rows)
            {
                string Id = rows.Cells[0].Value.ToString();
                if (Id == expense.ExpenseId)
                {
                    rows.Cells[1].Value = ExpenseManagerClass.GetCategory(expense.ExpenseCategoryId).Value.CategoryName;
                    rows.Cells[2].Value = expense.ExpenseAmount;
                    rows.Cells[3].Value = expense.ExpenseTime;
                    rows.Cells[4].Value = expense.ExpenseNotes;
                    break;
                }
            }
        }

        private void ExpenseDeleted(Expense expense)
        {
            foreach (DataGridViewRow rows in ExpenseGrid.Rows)
            {
                string Id = rows.Cells[0].Value.ToString();
                if (Id == expense.ExpenseId)
                {
                    ExpenseGrid.Rows.Remove(rows);
                }
            }
        } 
        #endregion

    }
}
