using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.IO;

namespace assignment7
{
    public delegate void delforUnderbalance(object source);
    public delegate void delforBalanceZero(object source, EventArgs e);

    public class Account
    {
        public int AccountNumber;
        public String CustomerName;
        public float Balance;
        public float Minbalance = 1000;
        public event delforUnderbalance UnderBalance;
        public event delforBalanceZero BalanceZero;

        public Account() { }
        public Account(int accountNumber, string customerName)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = Minbalance;




        }

        protected virtual void checkzerobalance()
        {
            if (Balance == 0)
            {
                BalanceZero(this, EventArgs.Empty);
            }

        }

        protected virtual void checkunderbalance()
        {

            UnderBalance(this);



        }
        public void Withdraw(float amount)

        {
            if (Balance == 0)
            {
                checkzerobalance();
            }
            else if ((Balance - amount) < Minbalance)
            {
                checkunderbalance();
            }
            else
                Balance = Balance - amount;
        }
        public void Deposit(float amount)
        {
            Balance = Balance + amount;
        }
    }


    public class program
    {

        public static void Main()
        {
            int accountNumber;
            string customerName;
            float amount, minbalance;
            bool dec = true;
            int n;
            List<Account> accounts = new List<Account>();
            string path = @"D:\AccountDetails\AccountDetails1.txt";
            do
            {
                Console.WriteLine("Enter action to perform \n1.Add an employee to file \n2. Display details from file ");
                n = Convert.ToInt32(Console.ReadLine());
                // Writing Customer information to a file
                switch (n) {



                    case 1:
                    using (StreamWriter sr = new StreamWriter(path))
                    {
                        Console.WriteLine("Enter account number");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter customer Name");
                        customerName = Console.ReadLine();
                        Account account = new Account(accountNumber, customerName);
                        accounts.Add(account);


                        sr.WriteLine($"Account number: {accountNumber}");
                        sr.WriteLine($"Customer name : {customerName}");
                        sr.WriteLine();
                        sr.Close();
                        }
                        break;
                        
                    case 2:

                    using (StreamReader sr = new StreamReader(path))
                    {
                        String s;

                        do
                        {
                            s = sr.ReadLine();
                            Console.WriteLine(s);
                        } while (s != null);
                    }
                        break;
            }
            
            } while (n == 1 || n == 2);
        }
    }
}                     




