using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class CombinationInAstringOfDigits
    {
        public void PrintCharacters(string s, int index = 0, int number = 1)
        {
            int loopcount = s.Length - number + 1;
            if (index >= s.Length)
            {
                SwitchGearsAndPrintCharacters(s, number);
                return;
            }
            Console.WriteLine(s.Substring(index, number));
            PrintCharacters(s, index + number, number);
        }
        public void SwitchGearsAndPrintCharacters(string s, int number)
        {
            if (number + 1 == s.Length)
            {
                Console.WriteLine(s);
                return;
            }
            PrintCharacters(s, number + 1);
        }
        public void printCombinations(char[] input,
                            int index,
                            char[] output,
                            int outLength)
        {
            // no more digits left in input string
            if (input.Length == index)
            {
                // print output string & return
                Console.WriteLine(String.Join("",
                                        output));
                return;
            }

            // place current digit in input string
            output[outLength] = input[index];

            // separate next digit with a space
            output[outLength + 1] = ' ';

            printCombinations(input, index + 1, output,
                                        outLength + 2);

            // if next digit exists make a
            // call without including space
            if (input.Length != index + 1)
                printCombinations(input, index + 1, output,
                                            outLength + 1);
        }


    }
}
