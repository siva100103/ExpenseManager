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
    public partial class ExpenseCreateForm : Form
    {
        public ExpenseCreateForm()
        {
            InitializeComponent();
            List<Category> categories=ExpenseManagerClass.GetAllCategories().Values.ToList();
            CategoryBox.DataSource = categories;
            CategoryBox.DisplayMember = "CategoryName";
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            Category category = (Category) CategoryBox.SelectedItem;
            DateTime time = DateTimePicker.Value;
            int amount = (int)AmountSelector.Value;
            string notes = NotesTextBox.Text;
            BooleanMsg res=ExpenseManagerClass.CreateExpense(category, amount, time, notes);
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
