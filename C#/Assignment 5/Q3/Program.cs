using LitwareLib;
using System.Collections;

class EmployeeManagement3
{
    public static void Main()
    {
        char cont;
        
        List<Employee> employees = new List<Employee>();
        do
        {
            Console.WriteLine("What Action do you want to perform \n 1.Add a new employee \n 2.Display the list of employees \n 3.Total number of employees in the list\n");
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
                default:
                    Console.WriteLine("Invalid Input");break;

            }
            Console.WriteLine("Do you want to Continue (y/n)");
            cont = Convert.ToChar(Console.ReadLine());
            
        } while (cont == 'y');

        
    }
    
}
