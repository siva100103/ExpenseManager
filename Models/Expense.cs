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

        public Expense(string categoryId, int expenseAmount, DateTime expenseTime, string expenseNotes)
        {
            ExpenseId = UniqueIdGenerator();
            ExpenseCategoryId = categoryId;
            ExpenseAmount = expenseAmount;
            ExpenseTime = expenseTime;
            ExpenseNotes = expenseNotes;
        }

        public Expense(string Id,string categoryId, int expenseAmount, DateTime expenseTime, string expenseNotes)
        {
            ExpenseId = Id;
            ExpenseCategoryId= categoryId;
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
