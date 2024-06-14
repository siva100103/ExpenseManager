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

    public partial class BudgetUpdateForm : Form
    {
        public Budget budget { get; set; }
        public BudgetUpdateForm(string BudgetId)
        {
            InitializeComponent();
            budget = ExpenseManagerClass.ReadBudget(BudgetId).Value;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MonthValueLabel.Text = budget.Month;
            YearValueLabel.Text = budget.Year;
            AmountValueBox.Value=budget.Amount;
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            int amount = (int)AmountValueBox.Value;
            BooleanMsg res = ExpenseManagerClass.UpdateBudget(budget.Month,budget.Year,amount);
            if (res)
            {
                Close();
                MessageBox.Show("Budget Updated SuccessFully...","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(res.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
