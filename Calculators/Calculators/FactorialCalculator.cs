using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class FactorialCalculator
    {
        public long CalculateFactorial(int num)
        {
            long CalcResult = num;
            if (num == 0)
            {
                return 0;
            }
            if (num < 0)
            {
                return -1;
            }
            if (num > 15)
            {
                return -3;
            }
            for (int i=num-1; i>1;i--)
            {
                CalcResult = CalcResult * i;
            }
            return CalcResult;
        }
    }
}
