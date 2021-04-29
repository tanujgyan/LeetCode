using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class DivisorGameClass
    {
        /// <summary>
        /// the idea is that the player playing will want to make it odd for the next player
        /// so if even number is there just subtract it by 1 if odd number is there
        /// reduce the number by 2 till you find a divisor and divide it by the number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool DivisorGame(int n)
        {
            int turn = 0;//alice turn
            
            do
            {
                if (n == 2)
                {
                    return true;
                }
                else if (n == 2 && turn == 1)
                {
                    return false;
                }
                if (n % 2 == 0 && n > 1)
                {
                    n--;
                }
                else if (n % 2 != 0)
                {
                    for (int i = n - 2; i >= 1; i -= 2)
                    {
                        if (n % i == 0)
                        {
                            n -= i;
                            break;
                        }
                    }
                }
                if(turn==0)
                {
                    turn = 1;//bobs turn
                }
                else
                {
                    turn = 0;
                }
            } while (n != 1);


           if(turn ==1)
            {
                return false;
            }
            return true;
        }
    }
}
