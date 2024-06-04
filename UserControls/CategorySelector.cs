using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.UserControls
{
    public partial class CategorySelector : UserControl
    {
        public delegate void CategoryCheckedChanged(string categoryId);
        public event CategoryCheckedChanged CategoryChecked;
        public event CategoryCheckedChanged CategoryUnchecked;
        public CategorySelector()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Category> categories = new List<Category>();
            using(DbManager dbManager =new DbManager())
            {
                categories = dbManager.Categories.ToList();
            }

                foreach (var category in categories)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Tag = category;
                    checkBox.AutoSize = false;
                    checkBox.Dock = DockStyle.Top;
                    checkBox.Text = category.CategoryName;
                    checkBox.Font = new Font("Microsoft Tai Le", 12, FontStyle.Regular);
                    checkBox.CheckedChanged += CheckBoxCheckedChanged;
                    CheckBoxPanel.Controls.Add(checkBox);
                }    
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string categoryId = (checkBox.Tag as Category).CategoryId;
            if(checkBox.Checked)
            {
                CategoryChecked?.Invoke(categoryId);
            }
            else
            {
                CategoryUnchecked?.Invoke(categoryId);
            }         
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
