using ExpenseManager.Models;
using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.ManagerClasses
{
    public static class ExpenseManagerClass
    {
        public delegate void ExpenseInformer(Expense expense);
        public static event ExpenseInformer ExpenseCreated;
        public static event ExpenseInformer ExpenseUpdated;
        public static event ExpenseInformer ExpenseDeleted;

        #region Expense
        public static BooleanMsg CreateExpense(Category category, int Amount, DateTime Time, string Notes)
        {
            if (category == null) return "Invalid Category";
            if (Amount <= 0) return "Amount Must be Greater Than Zero";

            Expense expense = new Expense(category, Amount, Time, Notes);
            using (var DbContext = new DbManager())
            {
                DbContext.Expenses.Add(expense);
                DbContext.SaveChanges();
            }
            ExpenseCreated?.Invoke(expense);

            return true;
        }

        public static BooleanMsg UpdateExpense(string ExpenseId, string categoryId, int amount, DateTime time, string notes)
        {
            using (DbManager DbContext = new DbManager())
            {
                Expense expense = DbContext.Expenses.Find(ExpenseId);
                if (expense == null) return "Invalid ExpenseId";
                Category category = GetCategory(categoryId);
                if (category == null) return "Invalid CategoryId";
                if (amount <= 0) return "Amount Cannot Be Negative";
                DbContext.Expenses.Remove(expense);
                DbContext.SaveChanges();
                expense.ExpenseCategoryId = categoryId;
                expense.ExpenseAmount = amount;
                expense.ExpenseTime = time;
                expense.ExpenseNotes = notes;
                DbContext.Expenses.Add(expense);
                DbContext.SaveChanges();
                ExpenseUpdated?.Invoke(expense);
                return true;

            }
        }

        public static BooleanMsg<Expense> ReadExpense(string Id)
        {
            using (DbManager DbContext = new DbManager())
            {
                Expense expense = DbContext.Expenses.Find(Id);
                if (expense == null) return "Invalid Expense Id";
                return expense;
            }
        }

        public static BooleanMsg DeleteExpense(string Id)
        {
            using (DbManager DbContext = new DbManager())
            {
                Expense expense = DbContext.Expenses.Find(Id);
                if (expense == null) return "Invalid Expense";
                DbContext.Expenses.Remove(expense);
                DbContext.SaveChanges();
                ExpenseDeleted?.Invoke(expense);
                return true;
            }
        }

        public static BooleanMsg AddExistingExpense(Expense expense)
        {
            using (DbManager DbContext = new DbManager())
            {
                DbContext.Expenses.Add(expense);
                DbContext.SaveChanges();
                return true;
            }
        }

        public static Dictionary<string, Expense> GetAllExpenses()
        {
            using (DbManager DbContext = new DbManager())
            {
                return DbContext.Expenses.ToDictionary(exp => exp.ExpenseId);
            }
        }
        #endregion

        #region Category
        public static BooleanMsg AddCategory(string name)
        {
            if (name == "") return "Enter Valid Name";
            using (DbManager DbContext = new DbManager())
            {
                Category c = DbContext.Categories.ToList().Find((cat) => cat.CategoryName.Equals(name));
                if (c != null) return "Category Already Exists";
                Category category = new Category(name);
                DbContext.Categories.Add(category);
                DbContext.SaveChanges();
            }
            return true;
        }

        public static BooleanMsg<Category> GetCategory(string Id)
        {
            using (DbManager DbContext = new DbManager())
            {
                Category category = DbContext.Categories.Find(Id);
                if (category == null) return "Invalid Category";
                return category;
            }
        }

        public static Dictionary<string, Category> GetAllCategories()
        {
            using (DbManager DbContext = new DbManager())
            {
                return DbContext.Categories.ToDictionary(cat => cat.CategoryId);
            }
        }
        #endregion
    }
}
