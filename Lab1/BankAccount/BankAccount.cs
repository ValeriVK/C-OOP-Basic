using System;

public class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance
        {
            get{  return this.balance; }
            set { this.balance = value; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                throw new Exception("Insufficient balance");
            }
           
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.ID}, balance {this.Balance:f2}";
        }
    }

