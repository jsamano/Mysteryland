using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDrinkStands
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(): base("Insufficient client account balance."){}
    }
}
