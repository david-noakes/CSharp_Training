using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class FactorialCalculator
    {
        public int CalculateFactorial(int num)
        {
            int CalcResult = num;
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
            if (num > 12)
            {
                return -2;
            }
            for (int i=num-1; i>1;i--)
            {
                CalcResult = CalcResult * i;
            }
            return CalcResult;
        }
    }
}
