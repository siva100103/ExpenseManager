using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Budget
    {
        public string BudgetId { get; set; }
        public int Amount { get; set; }

        public string Month { get; set; }
        public string Year { get; set; }
        public Budget(string Month,string Year,int amount)
        {
            BudgetId = Month + "," + Year;
            this.Month = Month;
            this.Year=Year;
            Amount = amount;
        }
        public Budget()
        {
            
        }
    }
}
