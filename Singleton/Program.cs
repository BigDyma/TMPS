using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var singleton1 = DatabaseConnection.GetInstance();
                var singleton2 = DatabaseConnection.GetInstance();
                if (singleton1 == singleton2)
                {
                    Console.WriteLine("Hurray! Both instances of Singleton references the same memory cell!");
                }
                else
                {
                    Console.WriteLine("Something's wrong - instances of Singleton references different memory cells!");
                }

                DatabaseConnection.GetInstance().Connection.Open(); 
            }
            finally
            {
                DatabaseConnection.GetInstance().Connection.Close();
            }

            Console.Read();
        }
    }
}
