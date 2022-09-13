
using LitwareLib;

class EmployeeManagement
{ 
    public static void Main()
    {
        Console.WriteLine("Enter number of employees to be entered");
        int n = int.Parse(Console.ReadLine());
        MarketingExecutive[] e = new MarketingExecutive[n];
        Employee[] c = new Employee[n];
        Manager[] a = new Manager[n];
        for (int i = 0; i < n; i++)
        {
            
            Console.WriteLine("Enter Employee no of employee {0}", i + 1);
      
            int EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of Employee {0}", i + 1);
            String EmpName = Console.ReadLine();
            Console.WriteLine("Enter salary of Employee {0}", i + 1);
            double Salary  = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter kilometer travel of Marketing executive {0}", i + 1);
            float KilometerTravel = float.Parse(Console.ReadLine());
            c[i] = new Employee(EmpNo, EmpName, Salary);
            c[i].CalculateSalary();
            Console.WriteLine("Gross salary and net salary of EMPLOYEE {0} is {1} and {2}", i + 1, c[i].GrossSalary, c[i].NetSalary);
            a[i] = new Manager(EmpNo, EmpName, Salary);
            a[i].CalculateSalary();
            Console.WriteLine("Gross salary and net salary of manager {0} is {1} and {2}", i + 1, a[i].GrossSalary, a[i].NetSalary);
            e[i] = new MarketingExecutive(EmpNo, EmpName, Salary, KilometerTravel);
            e[i].CalculateSalary();
            Console.WriteLine("Gross salary and net salary of marketing executive {0} is {1} and {2}", i + 1, e[i].GrossSalary, e[i].NetSalary);
        }
        

       

    }

   
}

