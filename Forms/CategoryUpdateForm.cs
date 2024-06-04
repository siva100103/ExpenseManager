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
    public partial class CategoryUpdateForm : Form
    {
        private string categoryId;

        public CategoryUpdateForm(string Id)
        {
            InitializeComponent();
            categoryId = Id;
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            BooleanMsg res = ExpenseManagerClass.UpdateCategory(categoryId,name);
            if (res.Result)
            {
                Close();
                MessageBox.Show("Category Updated Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(res.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
