using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        private String _Number;
        private String _Owner;
        private int _Balance;

        public Account() { }

        public Account(String number, String owner, int balance)
        {
            this._Number = number;
            this._Owner = owner;
            this._Balance = balance;
        }

        public Account(String number, String owner)
        {
            this._Number = number;
            this._Owner = owner;
            this._Balance = 0;
        }

        public bool Deposit(int amount)
        {
            this._Balance += amount;
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (this._Balance >= amount) {
                this._Balance -= amount;
                return  true;
            }
            else
            {
                return false;
            }

        }

        public String AccountInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("계좌번호: ").Append(this._Number).Append(Environment.NewLine);
            builder.Append("명의자: ").Append(this._Owner).Append(Environment.NewLine);
            builder.Append("잔액:  ").Append(this._Balance);
            return builder.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-213-124213-124", "이주훈", 1000);
            Account acc2 = new Account("001-213-15124213-124", "시험", 2000);
            Account acc3= new Account("001-213-1`124213-124", "싫다");
            Console.WriteLine(acc3.AccountInfo());

            acc1.Deposit(200);
            acc2.Deposit(3000);
            acc1.Deposit(20000);


            acc1.Withdraw(20000);
            acc2.Withdraw(20000);

            Console.WriteLine(acc1.AccountInfo());
            Console.WriteLine(acc2.AccountInfo());
        }
    }
}
