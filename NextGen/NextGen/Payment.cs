using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class Payment
    {
        private double amount;

        public Payment(double cashtendered)
        {
            amount = cashtendered;
        }

        public double getAmount()
        {
            return amount;
        }
    }
}