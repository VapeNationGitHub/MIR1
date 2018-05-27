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


/*
 https://ru.wikipedia.org/wiki/%D0%98%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D1%8C%D0%BD%D1%8B%D0%B5_%D0%BF%D0%BE%D0%B2%D1%82%D0%BE%D1%80%D0%B5%D0%BD%D0%B8%D1%8F
 Формула Интервального повторения Y=2X+1.
 Где Y - день, когда информация начнет забываться, забывание идет постепенно и равен Y дням, 
 X - день последнего повторения после заучивания.
*/
