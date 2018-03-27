using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            do
            {
                factorial *= n--;
            }
            while (n > 0);

            Console.WriteLine("Всего вариантов доставки: {0}", factorial);

            Console.ReadKey();
                
        }
    }
}
