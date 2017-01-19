using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        // Variables
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // Public methods
        public string FirstAndLastName()
        {
            return _firstName + " " + _lastName;
        }

        public override string ToString()
        {
            return FirstAndLastName() + " " + _weeklySalary.ToString("C");
        }

        // Constructors

        public Employee()
        {
            // Do nothing
        }

        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _weeklySalary = weeklySalary;
        }
    }
}
