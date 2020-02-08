using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseHunt.Models;

namespace HouseHunt.Repositories
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> GetAllExpenses();
        Expense GetExpenseById(int expenseId);
        void AddExpense(Expense expense);
        void Delete(int expenseId);
        Expense EditExpense(Expense expense);
    }
}
