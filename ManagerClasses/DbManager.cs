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

            string connectionString = ExpenseManagerClass.ReadLocalConnectionString();
            ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString,serverVersion);
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
