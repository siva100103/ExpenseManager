using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
//using GoLibrary;
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
    public partial class ExpenseCreateForm : Form
    {
        public ExpenseCreateForm()
        {
            InitializeComponent();
            List<Category> categories=ExpenseManagerClass.GetAllCategories().Values.ToList();
            categories.Sort((cat1, cat2) => cat1.CategoryName.CompareTo(cat2.CategoryName));
            CategoryBox.DataSource = categories;
            CategoryBox.DisplayMember = "CategoryName";
            DateTimePicker.MinDate = new DateTime(2020, 1, 1);
            DateTimePicker.MaxDate = DateTime.Now;
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            Category category = (Category) CategoryBox.SelectedItem;
            DateTime time = DateTimePicker.Value;
            int amount = (int)AmountSelector.Value;
            string notes = NotesTextBox.Text;
            BooleanMsg res=ExpenseManagerClass.CreateExpense(category.CategoryId, amount, time, notes);
            if (res.Result)
            {
                Close();
                MessageBox.Show("Expense Added Succesfully...!!!");
            }
            else
            {
                MessageBox.Show(res.Message);
            }
        }
    }
}
