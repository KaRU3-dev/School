using System;

namespace _20231002_Prac01_Okumura{
    internal class Program{
        public static void Main(string[] args){

            Console.Write("Please enter your balance: ");
            int balance = int.Parse(Console.ReadLine());
            Console.Write("Please enter your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            BankAccount bankAccount = new BankAccount(balance, accountNumber);

            bankAccount.GetBallance();

            Console.Write("Please enter your deposit amount: ");
            int depositAmount = int.Parse(Console.ReadLine());
            bankAccount.Deposit(depositAmount);

            bankAccount.GetBallance();

            Console.Write("Please enter your withdraw amount: ");
            int withdrawAmount = int.Parse(Console.ReadLine());
            bankAccount.Withdraw(withdrawAmount);

            bankAccount.GetBallance();
        }
    }


    public class BankAccount{
        private int _balance;
        private int _accountNumber;

        public int Balance{
            get { return _balance; }
            set {
                if (value > 0){
                    _balance = value;
                }
                else {
                    throw new ArgumentException("Balance cannot be null or empty");
                }
            }
        }

        public int AccountNumber{
            get { return _accountNumber; }
            set {
                if (value > 0){
                    _accountNumber = value;
                }
                else {
                    throw new ArgumentException("AccountNumber cannot be null or empty");
                }
            }
        }

        // Constructor
        public BankAccount(int balance, int accountNumber){
            Balance = balance;
            AccountNumber = accountNumber;
        }

        // Method
        public void GetBallance(){
            Console.WriteLine($"Balance: {Balance}");
        }
        public void Deposit(int amount){
            Balance += amount;
        }
        public void Withdraw(int amount){
            Balance -= amount;
        }
    }
}
