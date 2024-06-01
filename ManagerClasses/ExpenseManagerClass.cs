using ExpenseManager.Models;
//using GoLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.ManagerClasses
{
    public static class ExpenseManagerClass
    {
        public delegate void Informer(string Id);

        public static event Informer ExpenseCreated;
        public static event Informer ExpenseUpdated;
        public static event Informer ExpenseDeleted;

        public static event Informer CategoryCreated;
        public static event Informer CategoryUpdated;
        public static event Informer CategoryDeleted;

        #region Expense

        public static BooleanMsg AddExistingExpense(Expense expense)
        {
            using (DbManager DbContext = new DbManager())
            {
                DbContext.Expenses.Add(expense);
                DbContext.SaveChanges();
                return true;
            }
        }

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
            ExpenseCreated?.Invoke(expense.ExpenseId);

            return true;
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

        public static Dictionary<string, Expense> ReadExpenses(DateTime FromDate, DateTime ToDate, string categoryId)
        {
            using (DbManager DbContext = new DbManager())
            {
                var expenses = DbContext.Expenses
                    .Where(exp => exp.ExpenseTime.Date >= FromDate.Date && exp.ExpenseTime.Date <= ToDate.Date && (categoryId == null || exp.ExpenseCategoryId == categoryId))
                    .ToList();
                return expenses.ToDictionary(exp => exp.ExpenseId);
            }
        }

        public static Dictionary<string, Expense> ReadAllExpenses()
        {
            using (DbManager DbContext = new DbManager())
            {
                return DbContext.Expenses.ToDictionary(exp => exp.ExpenseId);
            }
        }

        public static BooleanMsg UpdateExpense(string ExpenseId, string categoryId, int amount, DateTime time, string notes)
        {
            using (DbManager DbContext = new DbManager())
            {
                Expense expense = DbContext.Expenses.Find(ExpenseId);
                if (expense == null) return "Invalid ExpenseId";
                Category category = (ReadCategory(categoryId)).Value;
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
                ExpenseUpdated?.Invoke(expense.ExpenseId);
                return true;

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
                ExpenseDeleted?.Invoke(expense.ExpenseId);
                return true;
            }
        }

        #endregion

        #region Category

        public static BooleanMsg CreateCategory(string name)
        {
            if (name == "") return "Enter Valid Name";
            using (DbManager DbContext = new DbManager())
            {
                Category c = DbContext.Categories.ToList().Find((cat) => cat.CategoryName.Equals(name));
                if (c != null) return "Category Already Exists";
                Category category = new Category(name);
                DbContext.Categories.Add(category);
                DbContext.SaveChanges();
                CategoryCreated?.Invoke(category.CategoryId);
            }
            return true;
        }

        public static BooleanMsg<Category> ReadCategory(string Id)
        {
            using (DbManager DbContext = new DbManager())
            {
                Category category = DbContext.Categories.Find(Id);
                if (category == null) return "Invalid Category";
                return category;
            }
        }

        public static BooleanMsg UpdateCategory(string Id, string name)
        {
            using (DbManager DbContext = new DbManager())
            {
                Category category = DbContext.Categories.Find(Id);
                if (category == null) return "Invalid Category";
                Category IsExist = DbContext.Categories.ToList().Find((cat) => cat.CategoryName.Equals(name));
                if (IsExist != null) return "CategoryAlready Exists";
                DbContext.Categories.Remove(category);
                DbContext.SaveChanges();

               

                category.CategoryName = name;
                DbContext.Categories.Add(category);
                DbContext.SaveChanges();
                CategoryUpdated?.Invoke(Id);
                return true;
            }
        }

        public static BooleanMsg DeleteCategory(string Id)
        {
            using (DbManager DbContext = new DbManager())
            {
                Category category = DbContext.Categories.Find(Id);
                if (category == null) return "Invalid Category";
                if (category.CategoryName == "Others") return "Cannot Delete this Category";
                DbContext.Categories.Remove(category);
                DbContext.SaveChanges();

                //For Changing the expense of that category to others
                string OthersId = DbContext.Categories.ToList().Find((cat) =>
                  {
                      return cat.CategoryName == "Others";
                  }).CategoryId;

                foreach (Expense expense in DbContext.Expenses.ToList())
                {
                    if (expense.ExpenseCategoryId == category.CategoryId)
                    {
                        UpdateExpense(expense.ExpenseId, OthersId, expense.ExpenseAmount, expense.ExpenseTime, expense.ExpenseNotes);
                    }
                }
                CategoryDeleted?.Invoke(category.CategoryId);
                return true;
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

        public static DateTime FirstExpenseDate()
        {
            using (DbManager DbContext = new DbManager())
            {
                List<Expense> expenses = DbContext.Expenses.ToList();
                if (expenses.Count == 0) return DateTime.MinValue;
                expenses.Sort((ex1, ex2) => ex1.ExpenseTime.CompareTo(ex2.ExpenseTime));
                return expenses[0].ExpenseTime;
            }
        }
        public static DateTime LastExpenseDate()
        {
            using (DbManager DbContext = new DbManager())
            {
                List<Expense> expenses = DbContext.Expenses.ToList();
                if (expenses.Count == 0) return DateTime.MaxValue;
                expenses.Sort((ex1, ex2) => ex2.ExpenseTime.CompareTo(ex1.ExpenseTime));
                return expenses[0].ExpenseTime;
            }
        }
        public static void MeasureStringHeight(string s,Font font)
        {

        }
    }
}
