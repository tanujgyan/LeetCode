using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/employee-importance/
    /// </summary>
    public class EmployeeImportanceClass
    {
        Stack<int> stack = new Stack<int>();
        int totalImp = 0;
        /// <summary>
        /// Solved using DFS technique
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetImportance(IList<Employee> employees, int id)
        {
            AddToStack(employees, id);
            return totalImp;
        }

        /// <summary>
        /// Take the employee id to start with and then for every subordinate in employee recursively call the same method
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="id"></param>
        public void AddToStack(IList<Employee> employees, int id)
        {
            totalImp += employees.FirstOrDefault(x => x.id == id).importance;
            if (employees[0] == null)
            {
                return;
            }
            foreach (var subid in employees.FirstOrDefault(x => x.id == id).subordinates)
            {
                AddToStack(employees, subid);
            }
        }
    }

    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}
