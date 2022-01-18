using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- N is an odd integer with the value 1 to 1,000,000
//-- Each element in array A is an integer with mixed values ​​from 1 to 1,000,000,000
//-- All values ​​in A occur an even number of times, with the exception of a single element

namespace Odd_Man_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] hardCodedArrayForShowingItWorks = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine(FindsOddManOut(hardCodedArrayForShowingItWorks));
            Console.ReadLine();
        }
        //-- The Logic to find the odd man out
        public static int FindsOddManOut(int[] array)
        {
            int vs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                vs = array[i];
                //-- since all the numbers are odd, we can add 1 to make it even
                array[i] += 1;
                //-- And then Scearh the array if there are any other matchs in it 
                if (!array.Contains(vs)) break;
                else array[i] -= 1;

            }
            return vs;
        }

    }
}
