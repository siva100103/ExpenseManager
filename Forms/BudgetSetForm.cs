using ExpenseManager.ManagerClasses;
using ExpenseManager.Models;
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

    public partial class BudgetSetForm : Form
    {
        public BudgetSetForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string[] arr = new string[] { "January","Feburary","March","April","May","June","July","Auguest","Septmber","October","November","December" };
            int CurrentMonth = DateTime.Now.Month;
            int CurrentYear = DateTime.Now.Year;
            for (int i = CurrentMonth-1; i < arr.Length; i++) MonthBox.Items.Add(arr[i]);
            for (int i = 0; i < 5; i++) YearBox.Items.Add(CurrentYear + i);
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if(MonthBox.SelectedItem==null ||YearBox.SelectedItem == null || AmountBox.Value<=0)
            {
                MessageBox.Show("Please select All the Values");
                return;
            }

            string Month=MonthBox.SelectedItem.ToString();
            string Year=YearBox.SelectedItem.ToString();
            int amount = (int)AmountBox.Value;
            BooleanMsg res = ExpenseManagerClass.CreateBudget(Month, Year, amount);
            if (res)
            {
                Close();
                MessageBox.Show("Budget Created Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Budget Already For This Period.If You Need to Override it press Ok", "Confirmation", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                ExpenseManagerClass.UpdateBudget(Month, Year, amount);
                MessageBox.Show("Budget Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }
    }
}
