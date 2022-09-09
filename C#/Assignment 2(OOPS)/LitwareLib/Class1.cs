namespace LitwareLib
{
    public class Employee
    {
        public int EmpNo;
        public string EmpName;
        public double Salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        public double GrossSalary{ get; set;}

        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
        
            if (this.Salary < 5000)
            {
                this.HRA = .1 * this.Salary;
                this.TA = .05 * this.Salary;
                this.DA = .15 * this.Salary;
            }
            else if (this.Salary < 10000)
            {
                this.HRA = .15 * this.Salary;
                this.TA = .1 * this.Salary;
                this.DA = .20 * this.Salary;
            }
            else if (this.Salary < 15000)
            {
                this.HRA = .2 * this.Salary;
                this.TA = .15 * this.Salary;
                this.DA = .25 * this.Salary;
            }
            else if (this.Salary < 20000)
            {
                this.HRA = .25 * this.Salary;
                this.TA = .2 * this.Salary;
                this.DA = .3 * this.Salary;
            }
            else
            {
                this.HRA = .3 * this.Salary;
                this.TA = .25 * this.Salary;
                this.DA = .35 * this.Salary;
            }

            this.GrossSalary = this.Salary + this.HRA + this.DA + this.TA;
        }

        public void CalculateSalary()
        {
            this.PF = .1 * this.GrossSalary;
            this.TDS = .18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);

        }

        public static void printDetails(Employee e,int i)
        {
            Console.WriteLine("Information of Employee {0} \n  EmployeeNo = {1} \n  EmployeeName = {2} \n  Salary = {3}\n  Gross Salary = {4}", i + 1, e.EmpNo, e.EmpName, e.Salary, e.GrossSalary);
        }
    }
}