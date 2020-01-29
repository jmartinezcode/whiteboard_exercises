using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class Sum2DigitsInArray
    {
        /*
        Given an array of integers, return indices of the two numbers such that 
        they add up to a specific target.You may assume that each input would 
        have exactly one solution, and you may not use the same element twice.
            Use Case:
                Given numbers in an array: [5, 17, 77, 50]
                Target: 55
        */

        // Use a nested loop to iterate over list

        public Sum2DigitsInArray()
        {

        }

        public void FindIndices(int[] array, int target)
        {
            bool foundTarget = false;
            if (foundTarget == false)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[i] + array[j] == target)
                        {
                            Console.WriteLine("Found solution, {0} and {1} equal {2}", array[i], array[j], target);
                            Console.WriteLine("The indices were {0} and {1}", i, j);
                            foundTarget = true;
                            i = j = array.Length; // To stop the nested loop, possibly use goto
                            break;
                        }
                    }                    
                }
            }
        }
    }
}

