using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__3
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract void DisplayDetails();
    }

    public interface IDiscountable
    {
        void ApplyDiscount(double percentage);
    }

    public class Electronics : Product, IDiscountable
    {
        public Electronics(string name, double price) : base(name, price) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Electronics: {Name}, Price: {Price}");
        }

        public void ApplyDiscount(double percentage)
        {
            Price -= Price * (percentage / 100);
            Console.WriteLine($"Discount applied to {Name}. New Price: {Price}");
        }
    }
    public class Clothing : Product, IDiscountable
    {
        public Clothing(string name,double price) : base(name, price) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Clothing: {Name}, Price: {Price}");
        }

        public void ApplyDiscount(double percentage)
        {
            Price -= Price * (percentage / 100);
            Console.WriteLine($"Discount applied to {Name}. New Price: {Price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Electronics("Laptop", 25000);
            laptop.DisplayDetails();
            ((IDiscountable)laptop).ApplyDiscount(10);
            laptop.DisplayDetails();

            Product shirt = new Clothing("Shirt", 1200);
            shirt.DisplayDetails();
            ((IDiscountable)shirt).ApplyDiscount(20);
            shirt.DisplayDetails();

            Console.ReadLine();
        }
    }
}