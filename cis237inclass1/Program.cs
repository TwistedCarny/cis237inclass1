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
            //UserInterface ui = new UserInterface();

            Employee myEmployee = new Employee();

            Employee[] employees = new Employee[10];

            string pathToCsv = "../employees.csv";

            CSVProcessor csvProccesor = new CSVProcessor();

            csvProccesor.ImportCSV(pathToCsv, employees);

            int choice = StaticUserInterface.GetUserInput();

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
                    StaticUserInterface.Output(outputString);
                }

                choice = StaticUserInterface.GetUserInput();
            }
        }
    }
}
