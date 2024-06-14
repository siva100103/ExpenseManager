using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
//using GoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.Forms
{
    [SupportedOSPlatform("windows")]

    public partial class ExpenseUpdateForm : Form
    {
        private string ExpenseId;
        public ExpenseUpdateForm(string Id)
        {
            InitializeComponent();
            ExpenseId = Id;
            DateTimePicker.MinDate = new DateTime(2020, 1, 1);
            DateTimePicker.MaxDate = DateTime.Now;
            ValueSetter();
        }

        private void ValueSetter()
        {
            List<Category> categories= ExpenseManagerClass.ReadAllCategories().Values.ToList();
            categories.Sort((cat1, cat2) => cat1.CategoryName.CompareTo(cat2.CategoryName));
            CategoryBox.DataSource = categories;
            CategoryBox.DisplayMember = "CategoryName";
            Expense expense = ExpenseManagerClass.ReadExpense(ExpenseId);
            if (expense == null)
            {
                Close();
                MessageBox.Show("Invalid Expense");
                return;
            }
            AmountSelector.Value = expense.ExpenseAmount;
            NotesTextBox.Text = expense.ExpenseNotes;
            DateTimePicker.Value = expense.ExpenseTime;
            CategoryBox.SelectedItem = ExpenseManagerClass.ReadCategory(expense.ExpenseCategoryId).Value;
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            string categoryId = ((Category)CategoryBox.SelectedItem).CategoryId;
            int amount = (int)AmountSelector.Value;
            DateTime time = DateTimePicker.Value;
            string notes = NotesTextBox.Text;
            BooleanMsg res = ExpenseManagerClass.UpdateExpense(ExpenseId,categoryId,amount,time,notes);
            if (res)
            {
                Close();
                MessageBox.Show("Expense Updated Successfully....", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(res.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
