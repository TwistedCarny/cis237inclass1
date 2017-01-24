using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                while((line = streamReader.ReadLine()) != null)
                {
                    ProcessLine(line, employees, counter);

                    counter++;
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                return false;
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                
            }
            
            
        }

        private void ProcessLine(string line, Employee[] employees, int index)
        {
            string[] parts = line.Split(',');

            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
