using SDESheet.Arrays;
using System;

namespace SDESheet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leaders 
            //int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
            //Leaders leaders = new Leaders(arr,arr.Length);

            //Equilibrium
            int[] arr = { 1, 3, 5, 2, 2 };
            Equilibrium equilibrium = new Equilibrium(arr, arr.Length);


            Console.Read();
        }
    }
}
