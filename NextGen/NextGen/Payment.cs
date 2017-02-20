using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class Payment
    {
        public double amount { get; }

        public Payment(double cashtendered)
        {
            amount = cashtendered;
        }
    }
}