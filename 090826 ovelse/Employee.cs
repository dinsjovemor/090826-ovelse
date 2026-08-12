using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Employee
    {
        public string NameEmployee { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public int EmployedYear { get; set; }
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
