
using LitwareLib;
class EmployeeManagement
{
    public static void Main()
    {
        Console.WriteLine("Enter number of employees to be entered");
        int n = int.Parse(Console.ReadLine());
        Employee[] e = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Employee no of employee {0}", i + 1);
      
            int EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of Employee {0}", i + 1);
            String EmpName = Console.ReadLine();
            Console.WriteLine("Enter salary of Employee {0}", i + 1);
            double Salary  = double.Parse(Console.ReadLine());
            e[i] = new Employee(EmpNo, EmpName, Salary);
            Console.WriteLine("Gross salary of employee {0} is {1}", i + 1, e[i].GrossSalary);
        }

    }
}