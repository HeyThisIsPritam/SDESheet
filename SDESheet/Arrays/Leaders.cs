using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDESheet.Arrays
{
    public class Leaders
    {
        public Leaders(int[] array,int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = i+1;  j< n; j++)
                {
                    if (array[i]<=array[j])
                    {
                        break;
                    }
                }
                if (j == n)
                {
                    Console.WriteLine(array[i]+" ");
                }
            }
        }
    }
}
