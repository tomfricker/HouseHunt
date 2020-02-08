using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseHunt.Models;

namespace HouseHunt.ViewModels
{
    public class ExpenseViewModel
    {
        public IEnumerable<Expense> Expenses { get; set; }
        public double Total { get; set; }
        public double RemainingBalance { get; set; }
    }
}
