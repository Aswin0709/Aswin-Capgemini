using LitwareLib;

namespace LitwareLib
{
    public interface IPrintable
    {
        void PrintDetailsofEmployee(Employee e);
    }


    public class Employee:IPrintable
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA , TA, DA, PF , TDS , NetSalary;
        public double GrossSalary;

        public double GetGrossSalary(){ return GrossSalary;}
        public Employee()
        {
            
        }

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

        public virtual void CalculateSalary()
        {
            this.PF = .1 * this.GrossSalary;
            this.TDS = .18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            //checking for changes
        }

        public void PrintDetailsofEmployee(Employee e)
        {
            Console.WriteLine("Information of Employees with Employee number: " + e.EmpNo+
                "\n Employee name: " + e.EmpName +"\n Salary: "+ e.Salary +"\n Gross Salary: "+e.GrossSalary +"\nNet Salary"+e.NetSalary );

        }
        public override string ToString()
        {
            return "\nEmp No: " + this.EmpNo + "\nEmp name: " + this.EmpName + "\nsalary: " + this.Salary ;
        }
    }

    public class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowances;

        public Manager(int empNo, string empName, double salary):base(empNo,empName,salary)
        {
            
            PetrolAllowance = .08 * this.Salary;
            FoodAllowance = .13 * this.Salary;
            OtherAllowances = .03 * this.Salary;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.PF = .1 * this.GrossSalary;
            GrossSalary = GrossSalary + (this.PetrolAllowance + this.FoodAllowance + this.OtherAllowances);
            this.TDS = .18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);


        }


    }

    public class MarketingExecutive:Employee
    {
        private float KilometerTravel;
        private float TourAllowance;
        private int TelephoneAllowances = 1000;

        public MarketingExecutive(int empNo, string empName, double salary):base(empNo, empName, salary)
        {
            this.TourAllowance = 5 * this.KilometerTravel;
            
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.PF = .1 * this.GrossSalary;
            GrossSalary = GrossSalary + this.TourAllowance + this.TelephoneAllowances;
            this.TDS = .18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);

        }


    }

   
}

