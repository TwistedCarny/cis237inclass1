using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            Employee myEmployee = new Employee();

            Employee[] employees = new Employee[10];

            employees[0] = new Employee("David", "Barnes", 835.00m);
            employees[1] = new Employee("James", "Kirk", 453.00m);
            employees[2] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[3] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[4] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[5] = new Employee("Johnathan", "Archer", 135.00m);

            int choice = ui.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string outputString = "";

                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            outputString += employee.ToString() + Environment.NewLine;
                        }
                    }

                    // Use the UI class to print put the string
                    ui.Output(outputString);
                }

                choice = ui.GetUserInput();
            }
        }
    }
}
