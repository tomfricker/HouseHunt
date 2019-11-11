using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseHunt.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Payee { get; set; }
        public double Amount { get; set; }
    }
}
