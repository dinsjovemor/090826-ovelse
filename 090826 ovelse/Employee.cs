using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Employee
    {
        public string NameEmployee;
        public string Lastname;
        public string JobTitle;
        public int EmployedYear;
        /// <summary>
        /// Constructor for Employee
        /// </summary>
        /// <param name="nameEmployee"></param>
        /// <param name="lastName"></param>
        /// <param name="jobTitle"></param>
        /// <param name="employedYear"></param>
        public Employee(string nameEmployee, string lastName, string jobTitle, int employedYear)
        {
            NameEmployee = nameEmployee;
            Lastname = lastName;
            JobTitle = jobTitle;
            EmployedYear = employedYear;

        }


    }
}
