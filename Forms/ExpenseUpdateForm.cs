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

namespace ExpenseManager.Forms
{
    public partial class ExpenseUpdateForm : Form
    {
        private string ExpenseId;
        public ExpenseUpdateForm(string Id)
        {
            InitializeComponent();
            ExpenseId = Id;
            ValueSetter();
        }

        private void ValueSetter()
        {
            CategoryBox.DataSource = ExpenseManagerClass.GetAllCategories().Values.ToList();
            CategoryBox.DisplayMember = "CategoryName";
            Expense expense = ExpenseManagerClass.ReadExpense(ExpenseId);
            AmountSelector.Value = expense.ExpenseAmount;
            NotesTextBox.Text = expense.ExpenseNotes;
            DateTimePicker.Value = expense.ExpenseTime;
            CategoryBox.SelectedItem = ExpenseManagerClass.GetCategory(expense.ExpenseCategoryId).Value;
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
            }
            else
            {
                MessageBox.Show(res.Message);
            }
        }
    }
}
