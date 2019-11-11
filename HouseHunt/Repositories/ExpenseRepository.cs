using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseHunt.Models;

namespace HouseHunt.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _appDbContext;

        public ExpenseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _appDbContext.Expenses;
        }

        public Expense GetExpenseById(int expenseId)
        {
            return _appDbContext.Expenses.FirstOrDefault(e => e.Id == expenseId);
        }

        public void AddExpense(Expense expense)
        {
            _appDbContext.Expenses.Add(expense);
            _appDbContext.SaveChanges();
        }

        public void Delete(int expenseId)
        {
            var expense = GetExpenseById(expenseId);
            _appDbContext.Expenses.Remove(expense);
            _appDbContext.SaveChanges();
        }

        public Expense EditExpense(Expense expense)
        {
            _appDbContext.Expenses.Update(expense);
            _appDbContext.SaveChanges();
            return expense;
        }
    }
}
