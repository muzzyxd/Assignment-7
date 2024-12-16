using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1__Interfaces_
{
    public interface IPayment
    {
        void MakePayment(double amount);
        string GenerateReceipt();
    }
    public class CreditCardPayment : IPayment
    {
        private double amount;

        public void MakePayment(double amount)
        {
            this.amount = amount;
            Console.WriteLine($"Processing credit card payment of {amount}");
        }

        public string GenerateReceipt()
        {
            return $"Credit Card Payment Receipt: Amount = {amount}";
        }
    }
    public class DebitCardPayment : IPayment
    {
        private double amount;

        public void MakePayment(double amount)
        {
            this.amount = amount;
            Console.WriteLine($"Processing debit card payment of {amount}");
        }

        public string GenerateReceipt()
        {
            return $"Debit Card Payment Receipt: Amount = {amount}";
        }
    }
    public class PayPalPayment : IPayment
    {
        private double amount;

        public void MakePayment(double amount)
        {
            this.amount = amount;
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }

        public string GenerateReceipt()
        {
            return $"PayPal Payment Receipt: Amount = {amount}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.MakePayment(5500.0);
            Console.WriteLine(creditCardPayment.GenerateReceipt());

            IPayment debitCardPayment = new DebitCardPayment();
            debitCardPayment.MakePayment(5000.0);
            Console.WriteLine(debitCardPayment.GenerateReceipt());

            IPayment payPalPayment = new PayPalPayment();
            payPalPayment.MakePayment(7500);
            Console.WriteLine(payPalPayment.GenerateReceipt());

            Console.ReadLine();
        }
    }
}