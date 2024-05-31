using ExpenseManager.ManagerClasses;
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
    public partial class CategoryCreateForm : Form
    {
        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            BooleanMsg res=ExpenseManagerClass.CreateCategory(name);
            if (res)
            {
                Close();
                MessageBox.Show("CategoryAdded Successfully...!!!");
            }
            else MessageBox.Show(res.Message);
        }
    }
}
