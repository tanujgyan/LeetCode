using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    /// <summary>
    /// https://leetcode.com/problems/robot-bounded-in-circle/
    /// </summary>
    class RobotBounded
    {
        /// <summary>
        /// The idea of algorithm is that once the robot finishes all instructions
        /// it will be either on 0,0 which means its a circle
        /// or if it is facing any direction but NORTH it will form a circle eventually
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public bool IsRobotBounded(string instructions)
        {
            int inputLength = instructions.Length;
            Robot robot = new Robot();
            for(int i=0;i<inputLength;i++)
            {
                if(instructions[i]=='G')
                {
                    if(robot.Direction=='N')
                    {
                        robot.Coordinate[1]++;
                    }
                    else if (robot.Direction == 'E')
                    {
                        robot.Coordinate[0]++;
                    }
                    else if (robot.Direction == 'W')
                    {
                        robot.Coordinate[0]--;
                    }
                    else if (robot.Direction == 'S')
                    {
                        robot.Coordinate[1]--;
                    }
                }
                else if(instructions[i]=='L')
                {
                    if (robot.Direction == 'N')
                    {
                        robot.Direction = 'W';
                    }
                    else if (robot.Direction == 'E')
                    {
                        robot.Direction = 'N';
                    }
                    else if (robot.Direction == 'W')
                    {
                        robot.Direction = 'S';
                    }
                    else if (robot.Direction == 'S')
                    {
                        robot.Direction = 'E';
                    }
                }
                else if (instructions[i] == 'R')
                {
                    if (robot.Direction == 'N')
                    {
                        robot.Direction = 'E';
                    }
                    else if (robot.Direction == 'E')
                    {
                        robot.Direction = 'S';
                    }
                    else if (robot.Direction == 'W')
                    {
                        robot.Direction = 'N';
                    }
                    else if (robot.Direction == 'S')
                    {
                        robot.Direction = 'W';
                    }
                }
            }
            if(robot.Coordinate[0]==0 && robot.Coordinate[1]==0)
            {
                return true;
            }
            else
            {
                if(robot.Direction=='N')
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Robot
    {
        public int[] Coordinate { get; set; }
        public char Direction { get; set; }
        public Robot()
        {
            Coordinate = new int[2] { 0, 0 };
            Direction = 'N';
        }
    }
}
