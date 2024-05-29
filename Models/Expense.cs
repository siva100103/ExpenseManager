using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Expense
    {
        public string ExpenseId { get; set; }
        public string ExpenseCategoryId { get; set; } 
        public int ExpenseAmount { get; set; }
        public DateTime ExpenseTime { get; set; }
        public string ExpenseNotes { get; set; }

        public Expense(Category expenseCategory, int expenseAmount, DateTime expenseTime, string expenseNotes)
        {
            ExpenseId = UniqueIdGenerator();
            ExpenseCategoryId = expenseCategory.CategoryId;
            ExpenseAmount = expenseAmount;
            ExpenseTime = expenseTime;
            ExpenseNotes = expenseNotes;
        }

        public Expense()
        {
           // ExpenseId = UniqueIdGenerator();
        }

        private string UniqueIdGenerator() => Guid.NewGuid().ToString(); // Changed to use GUID
    }
}
