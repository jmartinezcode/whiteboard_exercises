using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class CountPositiveNegative
    {
        /*
         *Create a method that takes an array of positive and negative numbers. 
         * Return an array where the first element is the count of the positive 
         * numbers and the second element is the sum of negative numbers. 
         *      Use case: 
         *      [7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21]
         *      
         *      Should return [6, 5]
         */

        // 
        
        public CountPositiveNegative()
        {
            int [] inputArray = { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21};  // outputs [6, 5]
            int [] outputArray = CreateCountArray(inputArray);
            DisplaySolution(outputArray);
        }

        public int CountNegatives(int[] array)
        {
            int negativeCount = 0;
            foreach (int item in array)
            {
                if (item < 0)
                {
                    negativeCount++;
                }
            }
            return negativeCount;
        }
        public int CountPositives(int[] array)
        {
            int positiveCount = 0;
            foreach (int item in array)
            {
                if (item > 0)
                {
                    positiveCount++;
                }                
            }
            return positiveCount;
        }
        public int[] CreateCountArray(int[] array)
        {
            int[] countArray = new int[2];
            countArray[0] = CountPositives(array);
            countArray[1] = CountNegatives(array);
            return countArray;
        }
        public void DisplaySolution(int[] array)
        {
            Console.WriteLine("The count array is:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
