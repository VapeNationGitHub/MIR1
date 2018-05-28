using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat:
            Console.Write("Введите, что вы хотите повторить: ");
            string userText = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userText))
            {
                Console.WriteLine("Значение не может быть пустым, повторите!");
                goto Repeat;
            }
            else if (userText != null)
            {
                LabelQuestion:
                Console.Write("Введите количество дней, когда вы последний раз повторяли информацию: ");
                string stringX = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(stringX))
                {
                    Console.WriteLine("Значение не может быть пустым, повторите!");
                    goto LabelQuestion;
                }
                else if (stringX != null)
                {
                    int X = Convert.ToInt32(stringX);
                    int Y = 2 * X + 1;

                    Console.WriteLine("Информация появится через " + Y + " дней");
                    Thread.Sleep(Y * 1000);
                    Console.WriteLine(userText);
                    Console.ReadLine();
                }
            }

            Console.Write("Хотите повторить? yes/no ");
            string rep = Console.ReadLine();
            if (rep == "yes") goto Repeat;
            if (rep == "no") return;

        }
    }
}
// 123