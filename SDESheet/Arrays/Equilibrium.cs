using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDESheet.Arrays
{
    public class Equilibrium
    {
        public Equilibrium(int[] a,int n)
        {
            int r_sum = 0;
            int sum = a.Sum();
            for (int i = 0; i < n; i++)
            {
                sum -= a[i];
                if (r_sum == sum)
                    Console.WriteLine(i+1);
                else
                    r_sum += a[i];
            }
        }
    }
}
