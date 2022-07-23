using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.SetInfo();
            Console.WriteLine(account1.GetInfo());

            Account<string> account2 = new Account<string>();
            account2.SetInfo();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
