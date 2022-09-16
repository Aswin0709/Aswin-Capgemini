

using LitwareLib;
using System.Collections;
using System.Collections.Generic;

class EmployeeManagement3
{
    public static void Main()
    {
        char cont;
        string findname;

        List<Employee> employees = new List<Employee>();
        List<MarketingExecutive> marketingExecutive = new List<MarketingExecutive>();
        do
        {
            Console.WriteLine("What Action do you want to perform \n 1.Add a new employee \n 2.Display the list of employees \n 3.Total number of employees in the list\n 4.Search Employee by name\n");
            int dec = Convert.ToInt32(Console.ReadLine());
            switch (dec)
            {
                case 1:
                    Console.WriteLine("Enter Employee no of employee");
                    int EmpNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name of Employee");
                    String EmpName = Console.ReadLine();
                    Console.WriteLine("Enter salary of Employee");
                    double Salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Kilometer Travelled");
                    float kilometertravel = float.Parse(Console.ReadLine());
                    employees.Add(new Employee(EmpNo, EmpName, Salary));
                    marketingExecutive.Add(new MarketingExecutive(EmpNo, EmpName, Salary,kilometertravel));

                    break;
                case 2:
                    for (int i = 0; i < employees.Count; i++)
                    {
                        employees[i].CalculateSalary();
                        marketingExecutive[i].CalculateSalary();

                        EmployeeDelegate del = new EmployeeDelegate(employees[i].PrintDetailsofEmployee);
                        del(employees[i]);
                        EmployeeDelegate del2 = new EmployeeDelegate(marketingExecutive[i].PrintDetailsofEmployee);
                        del2(marketingExecutive[i]);
                        //emp.PrintDetailsofEmployee(emp);
                    }
                    break;

                case 3:
                    Console.WriteLine($"The total no of employees in the list is {employees.Count}");
                    break;
                case 4:
                    Console.WriteLine("Enter name to be searched");
                    findname = Console.ReadLine();

                    Console.WriteLine(employees.Find(i => i.EmpName.Equals(findname)));

                    break;
                default:
                    Console.WriteLine("Invalid Input"); break;

            }
            Console.WriteLine("Do you want to Continue (y/n)");
            cont = Convert.ToChar(Console.ReadLine());

        } while (cont == 'y');


    }

}
