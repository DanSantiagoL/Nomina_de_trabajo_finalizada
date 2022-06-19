using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nomina_de_trabajo_finalizada
{
    internal class menu

    {
        public static void Main(string[] args)
        {


            Console.WriteLine("-Welcome user- \n");
            
            int opcion = 1;
            int NumberEmployee = 1;
            List<Data> data = new List<Data>();

                
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine($"\n -Do you want to calculate the payroll of employee number {NumberEmployee} ?- \n");
                Console.WriteLine("1 = Yes");
                Console.WriteLine("2 = No");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        
                        Data data1 = new Data();
                        ReadData(data1);
                        Calculations(data1);
                        resultsmenu(data1);
                        data.Add(data1);
                        Converttotext(data); break;

                    case 2: Console.Clear(); Console.WriteLine("-Exited from the program- \n"); Console.WriteLine("\n -Your payroll is located on the local disk C:-"); Environment.Exit(0); break;
                    default: Console.WriteLine("-The option is not valid please select a correct option- \n -Exited from the program-"); Environment.Exit(0); break;
                }
                Console.ReadKey();

                NumberEmployee++;


            }
            while (opcion != 2);

        }

        public static Data ReadData(Data data)
        {

            static double PedirDecimal()
            {
                string aux = Console.ReadLine();
                try
                {
                    return Convert.ToDouble(aux);
                }
                catch (Exception)
                {
                    return 0;
                }

            }

            do
            {
                Console.WriteLine("\n Insert ID number: ");
                data.Document = PedirDecimal();
            } while (data.Document <= 0);

            Console.WriteLine("Insert first name: ");
            data.FirstName = Console.ReadLine();

            Console.WriteLine("insert last name: ");
            data.LastName = Console.ReadLine();


            do
            {
                Console.WriteLine("Insert Salary: ");
                data.Salary = PedirDecimal();
            } while (data.Salary <= 0);

            do
            {
                Console.WriteLine("Insert Worked days in the month: ");
                data.WorkedDays = PedirDecimal();
               
                Console.Clear();

            } while (data.WorkedDays <= 0 || data.WorkedDays > 30);

            return data;
        }

        public static Data Calculations(Data data)
        {

            data.SubTransportation = 117172 / 30;
            data.SubTransportation = data.SubTransportation * data.WorkedDays;


            if (data.Salary <= 2000000)
            {
                data.TotalIncome = data.Salary + data.SubTransportation;
            }
            else
            {
                data.TotalIncome = data.Salary;
            }

            data.Accrual = data.TotalIncome / 30;
            data.Accrual = data.Accrual * data.WorkedDays;

            data.Health = data.Accrual * 0.04;
            data.Pension = data.Accrual * 0.04;

            return data;
        }

        public static Data resultsmenu(Data data)
        {

            Console.WriteLine("\nDocument: " + data.Document);
            Console.WriteLine("First Name: " + data.FirstName);
            Console.WriteLine("Last Name " + data.LastName);
            Console.WriteLine("Salary: " + data.Salary);
            Console.WriteLine("Worked days in the month: " + data.WorkedDays);
            Console.WriteLine("Total Income: " + data.TotalIncome);
            Console.WriteLine("Accrual: " + data.Accrual);

            Console.WriteLine("\n DISCOUNTS \n");
            Console.WriteLine("Health: " + data.Health);
            Console.WriteLine("Pension: " + data.Pension);
            Console.WriteLine("\n TOTAL PAYMENT (with discounts) \n");
            Console.WriteLine(data.Accrual - data.Health - data.Pension);
            Console.WriteLine(" ");
            Console.WriteLine("-press enter to continue-");
            


            return data;
        }
        public static void Converttotext(List<Data> data)
        {
            string file = "C:\\Payroll.txt";

                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(file, json);

            
        }

    }
}
    