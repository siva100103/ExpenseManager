using ExpenseManager.Forms;
using ExpenseManager.Models;
using Microsoft.EntityFrameworkCore.Storage;

//using GoLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;


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

        public static event Informer BudgetCreated;
        public static event Informer BudgetUpdated;
        public static event Informer BudgetDeleted;

        public static event Informer LimitExeceded;
        public static Dictionary<string, double> SpendedAmount = new Dictionary<string, double>();

        #region Expense

        public static BooleanMsg AddExistingExpense(string ExpenseId, string categoryId, int Amount, DateTime Time, string Notes)
        {
            //Validation...
            Category category = ReadCategory(categoryId);
            if (category == null) return "Invalid Category";
            if (Amount <= 0) return "Amount Must be Greater Than Zero";

            Expense expense = new Expense(ExpenseId, categoryId, Amount, Time, Notes);

            //Adding it to SpendedAmount...
            string s = GetMonth(expense.ExpenseTime.Month) + "," + expense.ExpenseTime.Year;
            if (SpendedAmount.ContainsKey(s)) SpendedAmount[s] += expense.ExpenseAmount;
            else SpendedAmount.Add(s, expense.ExpenseAmount);

            ExpenseCreated?.Invoke(expense.ExpenseId);

            return true;
        }
        private static string GetMonth(int month)
        {
            string[] arr = new string[] { "January", "Feburary", "March", "April", "May", "June", "July", "Auguest", "Septmber", "October", "November", "December" };
            return arr[month - 1];
        }
        public static BooleanMsg CreateExpense(string categoryId, int Amount, DateTime Time, string Notes)
        {
            //Validation....
            Category category = ReadCategory(categoryId);
            if (category == null) return "Invalid Category";
            if (Amount <= 0) return "Amount Must be Greater Than Zero";

            //Creating New Expense And Add it to Db....
            Expense expense = new Expense(category.CategoryId, Amount, Time, Notes);
            using (var DbContext = new DbManager())
            {
                DbContext.Expenses.Add(expense);
                DbContext.SaveChanges();
            }

            //Adding into Spended Amount...

            string s = GetMonth(expense.ExpenseTime.Month) + "," + expense.ExpenseTime.Year;
            
            if (SpendedAmount.ContainsKey(s)) SpendedAmount[s] += expense.ExpenseAmount;
            else SpendedAmount[s] = expense.ExpenseAmount;

            BudgetCheck(s);
            ExpenseCreated?.Invoke(expense.ExpenseId);

            return true;
        }
        private static void BudgetCheck(string s)
        {
            var budget = ReadAllBudgets();
            if(budget.ContainsKey(s) && budget[s].Amount <= SpendedAmount[s])
            {
                LimitExeceded?.Invoke(s);
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
            using (DbManager dbManager = new DbManager())
            {
                return dbManager.Expenses.OrderByDescending(exp => exp.ExpenseTime).ToDictionary((exp)=>exp.ExpenseId);
            }
        }

        public static BooleanMsg UpdateExpense(string ExpenseId, string categoryId, int amount, DateTime time, string notes)
        {
            using (DbManager DbContext = new DbManager())
            {
                //validation..
                Expense expense = DbContext.Expenses.Find(ExpenseId);
                if (expense == null) return "Invalid ExpenseId";
                Category category = ReadCategory(categoryId);
                if (category == null) return "Invalid CategoryId";
                if (amount <= 0) return "Amount Cannot Be Negative";

                //Deducting the Amount From spends
                string s = GetMonth(expense.ExpenseTime.Month) + "," + expense.ExpenseTime.Year;
                SpendedAmount[s] -= expense.ExpenseAmount;

                //Updating Expense..
                expense.ExpenseCategoryId = categoryId;
                expense.ExpenseAmount = amount;
                expense.ExpenseTime = time;
                expense.ExpenseNotes = notes;
                DbContext.SaveChanges();
                
                //Adding the UpdatedAmount to spends...
                s = GetMonth(expense.ExpenseTime.Month) + "," + expense.ExpenseTime.Year;
                SpendedAmount[s] += expense.ExpenseAmount;
                BudgetCheck(s);
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
                string s = GetMonth(expense.ExpenseTime.Month) + "," + expense.ExpenseTime.Year;
                SpendedAmount[s] -= expense.ExpenseAmount;
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
                category.CategoryName = name;
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

        public static Dictionary<string, Category> ReadAllCategories()
        {
            using (DbManager DbContext = new DbManager())
            {
                return DbContext.Categories.OrderBy(cat=>cat.CategoryName).ToDictionary(cat => cat.CategoryId);
            }
        }

        #endregion


        #region Budgets
        public static BooleanMsg CreateBudget(string month, string year, int amount)
        {
            string s = month + "," + year;
            Budget budget = ReadBudget(s);
            if (budget != null) return "Budget Already Exists";
            budget = new Budget(month, year, amount);
            using (DbManager dbManager = new DbManager())
            {
                dbManager.Add(budget);
                dbManager.SaveChanges();
                BudgetCreated?.Invoke(s);
                return true;
            }
        }
        public static BooleanMsg<Budget> ReadBudget(string budgetId)
        {
            using (DbManager dbManager = new DbManager())
            {

                Budget budget = dbManager.Budgets.Find(budgetId);
                if (budget == null) return "Invalid Budget";
                return budget;
            }
        }
        public static Dictionary<string,Budget> ReadAllBudgets()
        {
            using(DbManager dbManager=new DbManager())
            {
                return dbManager.Budgets.ToDictionary(budget=>budget.BudgetId);
            }
        }
        public static BooleanMsg UpdateBudget(string month,string year,int amount)
        {
            string Id=month+","+year;
            using(DbManager dbManager = new DbManager())
            {
                Budget budget=dbManager.Budgets.Find(Id);
                if (budget == null) return "Invalid Budget";
                budget.Amount = amount;
                dbManager.SaveChanges();
                BudgetUpdated?.Invoke(Id);
                return true;
            }
        }        
        public static BooleanMsg DeleteBudget(string BudgetId)
        {
            using(DbManager dbManager=new DbManager())
            {
                Budget budget=dbManager.Budgets.Find(BudgetId);
                if (budget == null) return "Invalid Budget";
                dbManager.Budgets.Remove(budget);
                dbManager.SaveChanges();
                BudgetDeleted?.Invoke(BudgetId);
                return true;
            }
        }

        #endregion

        #region DataBase
        public static bool CheckDbConfiguration()
        {
            string s = @".\LocalDb.xml";
            if (!File.Exists(s))
            {
                XmlDocument LocalDb = new XmlDocument();

                // Create a root element
                XmlElement root = LocalDb.CreateElement("LocalDb");
                LocalDb.AppendChild(root);

                // Create child elements
                XmlElement port = LocalDb.CreateElement("Port");
                port.InnerText = "3306";
                root.AppendChild(port);

                XmlElement UId = LocalDb.CreateElement("UId");
                UId.InnerText = "root";
                root.AppendChild(UId);

                XmlElement pwd = LocalDb.CreateElement("Password");
                pwd.InnerText = "";
                root.AppendChild(pwd);

                LocalDb.Save(s);
            }

            try
            {
                DbManager dbManager = new DbManager();
                dbManager.Database.EnsureCreated();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static void UpdateDbConfiguration(string Port, string UId, string Password)
        {
            string filePath = @"./LocalDb.xml";
            XmlDocument LocalDb = new XmlDocument();
            LocalDb.Load(filePath);

            LocalDb.GetElementsByTagName("Port").Item(0).InnerText = Port;
            LocalDb.GetElementsByTagName("UId").Item(0).InnerText = UId;
            LocalDb.GetElementsByTagName("Password").Item(0).InnerText = Password;
            LocalDb.Save(filePath);
        }
        public static string ReadLocalConnectionString()
        {
            string s = @"./LocalDb.xml";
            XmlDocument LocalDb = new XmlDocument();
            LocalDb.Load(s);

            string port = LocalDb.GetElementsByTagName("Port").Item(0).InnerText;
            string Uid = LocalDb.GetElementsByTagName("UId").Item(0).InnerText;
            string pwd = LocalDb.GetElementsByTagName("Password").Item(0).InnerText;


            string connectionString = $"server=localhost;port={port};uid={Uid};pwd={pwd};database=expensedatabase";
            return connectionString;
        }
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
        #endregion
    }
}

