using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class SequenceTester
    {
        /*Given a list of integers, return a bool that represents whether 
         * all integers in the list can form a sequence of incrementing integers
         *      Use case: 
         *          {5, 7, 3, 8, 6} => false (no 4 to complete the sequence)
         *          {17, 15, 20, 19, 21, 16, 18} => true         * 
         * 
         */

        // Sort list
        // Verify i and i+1 are sequential (add 1 to set equal)
        // list[i] + 1 == list[i+1]
        List<int> listToCheck;
        
        public SequenceTester()
        {
            //listToCheck = new List<int> { 5, 7, 3, 8, 6 }; // Should return false
            listToCheck = new List<int> { 17, 15, 20, 19, 21, 16, 18 }; // Should return true
            listToCheck.Sort();
            //TestSequence(listToCheck);
            DisplayInfo();
        }
        public bool TestSequence(List<int> sortedList)
        {
            bool isSequenced = false;
            int count = 0;
            for (int i = 0; i < sortedList.Count-1; i++)
            {
                if (sortedList[i] + 1 == sortedList[i + 1])
                {
                    count++;
                    //break;
                }
            }
            if (count == sortedList.Count - 1)
            {
                isSequenced = true;
            }
            return isSequenced;
        }
        public void DisplayInfo()
        {
            if (TestSequence(listToCheck))
            {
                Console.WriteLine("True, the list can be put in sequence");
                Console.Write("The ordered list is:\n");
                foreach (int item in listToCheck)
                {
                    Console.Write("{0} ", item);
                }                
            }
            else
            {
                Console.WriteLine("False, the list can NOT be put in sequence");
                Console.Write("The ordered list is:\n");
                foreach (int item in listToCheck)
                {
                    Console.Write("{0} ", item);
                }
            }                        
        }
    }
}
