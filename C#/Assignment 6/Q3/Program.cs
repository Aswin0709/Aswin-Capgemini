
using System.Reflection.Metadata.Ecma335;
using System.Collections;

namespace Banker
{
    public delegate void delforUnderbalance(object source);
    public delegate void delforBalanceZero(object source, EventArgs e); 

    public class Account
    {
        public int AccountNumber;
        public String CustomerName;
        public float Balance;
        public float Minbalance =1000;
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
            float amount,minbalance;
            bool dec = true;
            List<Account> accounts = new List<Account>();
            Managezerobalance zb = new Managezerobalance();
            Manageunderbalance ub = new Manageunderbalance();


            while (dec)
            {


                Console.WriteLine("What Action do you want to perform\n 1.Add Account Details\n 2.Deposit money\n 3.Withdraw money\n 4.View Balance\n 5.Exit");
                int decision = Convert.ToInt32(Console.ReadLine());

                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Enter account number");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter customer Name");
                        customerName = Console.ReadLine();
                          
                        Account account = new Account(accountNumber, customerName );

                        accounts.Add(account);
                        break;
                    case 2:
                        Console.WriteLine("Enter Account Number");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Amount to be deposited");
                        amount = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < accounts.Count; i++)
                        {
                            if (accounts[i].AccountNumber.Equals(accountNumber))
                            { accounts[i].Deposit(amount); break; }
                            else
                                Console.WriteLine("Enter valid account number");
                            break;
                        }


                        break;

                    case 3:
                        Console.WriteLine("Enter Account Number");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Amount to be withdrawn");
                        amount = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < accounts.Count; i++)
                        {
                            if (accounts[i].AccountNumber.Equals(accountNumber))
                            {
                                
                                accounts[i].UnderBalance += ub.checkunderbalance;
                                accounts[i].BalanceZero += zb.checkzerobalance;
                                accounts[i].Withdraw(amount); break;
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Account Number");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < accounts.Count; i++)
                        {
                            if (accounts[i].AccountNumber.Equals(accountNumber))
                            { Console.WriteLine($"The account balance is: {accounts[i].Balance}"); break; }
                        }
                        break;

                    case 5:
                        dec = false;
                        break;





                }
            }
        }
    }
    public class Managezerobalance
    {
        public void checkzerobalance(object source, EventArgs e)
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
        }

    }
    public class Manageunderbalance
    {
        public void checkunderbalance(object source)
        {
            Console.WriteLine("Transaction cannot be continued as balance is less than 1000");
        }
    }
  
   
}


