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
    public partial class CategoryAddForm : Form
    {
        public CategoryAddForm()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            BooleanMsg res=ExpenseManagerClass.AddCategory(name);
            if (res) Close();
            else MessageBox.Show(res.Message);
        }
    }
}
