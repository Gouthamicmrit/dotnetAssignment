using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetAssignment
{
    class Accounts
    {
        string accntno;
        string cusname;
        string accnttype;
        string transctype;
        double amount;
        double balance = 0;

        public Accounts(string accntno, string cusname, string accnttype)
        {
            this.accntno = accntno;
            this.cusname = cusname;
            this.accnttype = accnttype;

        }

        public void display()
        {
            Console.WriteLine("Account number is : " + accntno);
            Console.WriteLine("Customer name is : " + cusname);
            Console.WriteLine("Account number is : " + accnttype);

        }

        public void withdrawal(double x)
        {
            amount = x;
            balance -= amount;
            Console.WriteLine("the balance is : " + balance);
            Console.ReadLine();
        }

        public void Deposit(double y)
        {
            amount = y;
            balance += amount;
            Console.WriteLine("the balance is : " + balance);
            Console.ReadLine();
        }
    }
        internal class Assignment2question1
    {
        static void main(string[] args)
        {
            Accounts accounts = new Accounts("iob1234", "gouthami", "savings");
            string ops;
            Console.WriteLine("enter the transaction type\n1.Withdrawal\n2.Deposit\n");
            ops = Console.ReadLine();
            accounts.display();
            
            switch (ops)
            {
                case "1.Withdrawal":
                    {
                        accounts.withdrawal(500);

                        break;
                    }

                case "2.Deposit":
                    {
                        accounts.Deposit(1000);
                        break;
                    }


            }
            //Console.WriteLine("THANK YOU");
            Console.ReadLine();



        }
    }
}
