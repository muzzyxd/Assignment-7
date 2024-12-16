using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__Interfaces_
{
    interface IWork
    {
        void StartWork();
        void EndWork();
    }

    public class Developer : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Developer is starting to write code.");
        }

        public void EndWork()
        {
            Console.WriteLine("Developer has finished coding for the day.");
        }
    }

    public class Manager : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Manager is starting the team meeting.");
        }

        public void EndWork()
        {
            Console.WriteLine("Manager has completed the team meeting and is wrapping up.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWork developer = new Developer();
            developer.StartWork();
            developer.EndWork();

            IWork manager = new Manager();
            manager.StartWork();
            manager.EndWork();

            Console.ReadLine();
        }
    }
}
