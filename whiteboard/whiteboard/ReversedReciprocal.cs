using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboard
{
    class ReversedReciprocal
    {
        /* 
         * Given a number, return the reciprocal of the reverse of the original number, as a double. 
         * Use case: If given 17, return 0.01408 (1/71)
         * 
         */

        // get input
        // reverse input
        
        // return reciprocal         
        public ReversedReciprocal()
        {
            int number = GetUserInput();
            int reversed = ReverseNumber(number);
            double solution = CalculateReciprocal(reversed);
            DisplaySolution(number, reversed, solution);
        }
        public int GetUserInput()
        {
            int temporaryCheck;
            do
            {
                Console.WriteLine("Please enter any integer greater than 10");
                string input = Console.ReadLine();
                int.TryParse(input, out temporaryCheck); 
            } while (temporaryCheck <= 10);
            return temporaryCheck;
        }
        public int ReverseNumber(int input)
        {
            int reverseNumber = 0;
            while (input > 0)
            {
                reverseNumber = reverseNumber * 10 + input % 10;
                input /= 10;
            }
            return reverseNumber;
        }
        public double CalculateReciprocal(int input)
        {
            return 1.0 / input;
        }
        public void DisplaySolution(int number, int reversedNumber, double reversedReciprocal)
        {
            Console.WriteLine("You entered: {0}\nThe reversed number is: {1}\nThe reversed reciprocal is {2}",number , reversedNumber, reversedReciprocal);
        }

    }
}
