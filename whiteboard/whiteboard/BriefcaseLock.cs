using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class BriefcaseLock
    {
        /*A briefcase has a four-digit rolling-lock. 
         * Each digit is a number from 0-9 that can be rolled either forwards or backwards. 
         * Write a method that returns the smallest number of turns it takes to transform the 
         * lock from current combination to the target combination. 
         * One turn is equivalent to rolling a number forwards or backwards by one. 
         *      Use case: 
         *          Current lock: 3893
         *          Target lock: 5296
         *      Should return:
         *      2 + 4 + 0 + 3 = 9 turns needed to unlock         * 
         */

        // current
        // target
        // maxDistance = 5 (per digit)
        int startCombo;
        int finishCombo;
        int[] start;
        int[] target;
        int numberOfturns;
        public BriefcaseLock()
        {
            startCombo = GetUserInput();
            finishCombo = GetUserInput();
            start = ArrayCreator(startCombo);
            target = ArrayCreator(finishCombo);
            numberOfturns = CalculateTotalTurns(start, target);
            DisplayInfo(startCombo, finishCombo, numberOfturns);
        }
        public int GetUserInput()
        {
            int userInput;
            do
            {
                Console.WriteLine("Please enter a 4 digit combination");
                string input = Console.ReadLine();
                int.TryParse(input, out userInput);
            } while (userInput < 1000 && userInput > 9999);
            return userInput;
        }

        public int[] ArrayCreator(int number)
        {
            int [] result = new int[4];
            for (int i = result.Length - 1; i >= 0; i--)
            { //decrement through number to create array of integers
                result[i] = number % 10;
                number /= 10;
            }
            return result;
        }
        public int ReturnDifference(int start, int target)
        {
            // compare each digit to determine distance
            int absoluteDifference = Math.Abs(start - target);
            int oppositeDifference = Math.Min(start, target) + 10 - Math.Max(start, target);
            int minimumDifference = Math.Min(absoluteDifference, oppositeDifference);
            return minimumDifference;
        }
        public int CalculateTotalTurns(int [] start, int [] target)
        {
            int numberOfTurns = 0;
            for (int i = 0; i < start.Length; i++)
            {
                numberOfTurns += ReturnDifference(start[i], target[i]);
            }
            return numberOfTurns;
        }
        public void DisplayInfo(int start, int target, int numberOfTurns)
        {
            Console.WriteLine("You entered the start combo as: {0}\nYou entered the finish combo as: {1}\nIt takes {2} turns to reach the combination", start, target, numberOfTurns);
        }
    }
}
