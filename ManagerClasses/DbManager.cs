﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using ExpenseManager.Models;
using System.Xml;

namespace ExpenseManager.ManagerClasses
{
    public class DbManager : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string s = @"./LocalDb.xml";
            //XmlDocument LocalDb = new XmlDocument();
            //LocalDb.Load(s);

            //string port = LocalDb.GetElementsByTagName("Port").Item(0).InnerText;
            //string Uid = LocalDb.GetElementsByTagName("UId").Item(0).InnerText;
            //string pwd = LocalDb.GetElementsByTagName("Password").Item(0).InnerText;

            string ConnectionString = $"server=localhost;port=3306;uid=root;pwd=Suriya@123;database=expensedatabase";

            //string connectionString = $"server=localhost;port={port};uid={Uid};pwd={pwd};database=expensedatabase";
            optionsBuilder.UseMySql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Expense>().HasKey(ex => ex.ExpenseId);
            modelBuilder.Entity<Category>().HasKey(cat => cat.CategoryId);
            modelBuilder.Entity<Budget>().HasKey(budget => budget.BudgetId);

            modelBuilder.Entity<Expense>().Property(ex => ex.ExpenseId)
                .HasColumnType("varchar(36) CHARACTER SET utf8mb4");
            modelBuilder.Entity<Category>().Property(cat => cat.CategoryId)
                .HasColumnType("varchar(36) CHARACTER SET utf8mb4");
            modelBuilder.Entity<Budget>().Property(budget => budget.BudgetId)
                .HasColumnType("varchar(36) CHARACTER SET utf8mb4");

           
        }
    }
}
