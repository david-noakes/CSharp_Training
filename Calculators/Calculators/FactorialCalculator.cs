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
            if (num <= 0)
            {
                return 0;
            }
            if (num > 32768)
            {
                return -1;
            }
            for (int i=num-1; i>0;i--)
            {
                CalcResult = CalcResult * i;
            }
            return CalcResult;
        }
    }
}
