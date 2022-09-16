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
                    employees.Add(new Employee(EmpNo,EmpName,Salary));
                    break;
                case 2:
                    foreach(Employee emp in employees)
                    {
                        Console.WriteLine(emp.ToString());
                    }
                    break;

                case 3:
                    Console.WriteLine($"The total no of employees in the list is {employees.Count}");
                    break;
                case 4:
                    Console.WriteLine( "Enter name to be searched");
                    findname = Console.ReadLine();

                    Console.WriteLine(employees.Find(i => i.EmpName.Equals(findname)));

                    break;
                default:
                    Console.WriteLine("Invalid Input");break;

            }
            Console.WriteLine("Do you want to Continue (y/n)");
            cont = Convert.ToChar(Console.ReadLine());
            
        } while (cont == 'y');

        
    }
    
}
