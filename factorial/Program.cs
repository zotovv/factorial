using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static double Factorial(int f, int n)
        {
            //do
            //{
            //    f *= n--;
            //}
            //while (n > 0);

            //return f;

            if (n == 1)
                return 1;
            else
            {
                for(int i = n; i > 0; i--)
                {
                    f *= i;
                }
                return f;
            }   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            Console.WriteLine("Всего вариантов доставки: {0}", Factorial(factorial, quantity));

            Console.ReadKey();
                
        }
    }
}
