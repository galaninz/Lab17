using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class Account<T>
    {
        private T Id {get;set;}
        private int Balance { get;set;}
        private string Name {get;set;}

        public string GetInfo()
        {
            return $"{Id} {Balance} {Name}";
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите номер счета");
            Id = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }

    }
}
