using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
  public  class Expense
    {
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }




        public Expense()
        {

        }

        public Expense(string category,decimal amount,DateTime date)
        {
            Category = category;
            Amount = amount;
            ExpenseDate = date;
        }
        public override string ToString()
        {
            return $"{Category}{Amount:c} on{ExpenseDate.ToShortDateString()}";
        }
    }
}
