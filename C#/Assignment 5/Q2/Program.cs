using LitwareLib;
using System.Collections;

class  EmployeeManagement2

    
{
    
    public static void Main()
    {
        ArrayList arr = new ArrayList();
        Console.WriteLine("Enter number of employees to be entered");
        int n = int.Parse(Console.ReadLine());



        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("Enter Employee no of employee {0}", i + 1);
            int EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of Employee {0}", i + 1);
            String EmpName = Console.ReadLine();
            Console.WriteLine("Enter salary of Employee {0}", i + 1);
            double Salary = double.Parse(Console.ReadLine());
            Employee emp = new Employee(EmpNo,EmpName,Salary);
            arr.Add(emp);   
        }
        for (int i = 0; i < n; i++)
        {  // overrided ToString function in Employee class
            Console.WriteLine(arr[i].ToString());
        }

    }

}