using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class StrongPassword
    {
        public static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            int result = 0;
            string specialCharacters = "!@#$%^&*()-+";
            int lowercase = 0;
            int specialchar = 0;
            int uppercase = 0;
            int numbers = 0;
            foreach(char c in password)
            {
                if(Char.IsUpper(c))
                {
                    uppercase++;
                }
                else if (Char.IsLower(c))
                {
                    lowercase++;
                }
                else if (specialCharacters.Contains(c))
                {
                    specialchar++;
                }
                else if(Char.IsNumber(c))
                {
                    numbers++;
                }
            }
            if(uppercase==0)
            {
                n++;
                result++;
            }
            if(lowercase==0)
            {
                n++;
                result++;
            }
            if(specialchar==0)
            {
                n++;
                result++;
            }

            if(numbers==0)
            {
                n++;
                result++;
            }
            if (n >= 6)
            {
                return result;
            }
            else
            {
                result = 6 - n + result;
            }
            return result;

            
        }
    }
}
