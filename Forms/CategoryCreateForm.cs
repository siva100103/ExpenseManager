using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;

///using GoLibrary;
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
                MessageBox.Show("CategoryAdded Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show(res.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
