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
            string s1 = "apple";
            string s2 = "away";
            string s3 = "hello";
            string s4 = "bye";
            string[] values = new string[] {s1, s2, s3, s4 };
            String s10 = String.Join(", ", values); // метод Join для объединения сторк; получеам два параметра:  
            //строку-разделитель ", " и массив строк, которые будут соединяться и разделяться разделителем.
            Console.WriteLine("Введите одно из слово, которое вы хотите повторить: " + s10);
            string userText = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userText))
            {
                Console.WriteLine("Значение не может быть пустым, повторите!");
                goto Repeat;
            }
            else if (userText == s1 | userText == s2 | userText == s3 | userText == s4)
            {
                
                LabelQuestion:
                Console.Write("Введите количество дней, когда вы последний раз повторяли слово: ");
                string daysX = Console.ReadLine();
               

                if (String.IsNullOrWhiteSpace(daysX))
                {
                    Console.WriteLine("Значение не может быть пустым, повторите!");
                    goto LabelQuestion;
                }
                else if (daysX != null)
                {
                    int X = Convert.ToInt32(daysX);
                    int Y = 2 * X + 1; 

                    
                    Console.WriteLine("Введите слово через " + Y + " дня(ей) для повторения ");
                    Thread.Sleep(Y * 1000);
                    Console.WriteLine("Введите слово: "); 

                    RepeatWord:
                    string word = Console.ReadLine();
                    if (word == s1 | word == s2 | word == s3 | word == s4) 
                        
                    {
                        Console.WriteLine("Слово введно правильно.");
                        int Z = Y * 2;
                        Console.WriteLine("Для закрепления введите слово через " + Z + " дня(ей) ");
                        Thread.Sleep(Z * 1000);
                        Console.WriteLine("Введите слово: "); 

                        RepeatWord1:
                        string word1 = Console.ReadLine();
                        if (word1 == s1 | word1 == s2 | word1 == s3 | word1 == s4)
                        {
                            Console.WriteLine("Слово введно правильно! Вы молодец :)");
                            int C = Z * 2;
                            Console.WriteLine("Для окончательного запоминания слова, введите его через " + C + " дня(ей) ");
                            Thread.Sleep(Z * 1000);
                            Console.WriteLine("Введите слово: "); 


                            string word2 = Console.ReadLine();
                            if (word2 == s1 | word2 == s2 | word2 == s3 | word2 == s4)
                            {
                                Console.WriteLine("Слово введно правильно! Вы закончили обучение! Поздравляем! :) ");
                                goto LableLast;
                            }
                            else
                            {
                                Console.WriteLine("Слово введено не правильно и вы возвращаетесь на стадию назад :(");
                                Console.WriteLine("Повторно введите слово через " + C + " дня(ей) ");
                                Thread.Sleep(C * 1000);
                                Console.WriteLine("Введите слово: ");
                            } goto RepeatWord1;
                        }
                        else
                        {
                            Console.WriteLine("Слово введено не правильно и вы возвращаетесь на стадию назад :(");
                            Console.WriteLine("Повторно введите слово через " + Z + " дня(ей) ");
                            Thread.Sleep(Z * 1000);
                            Console.WriteLine("Введите слово: ");
                        }
                        goto RepeatWord;
                    }
                    else
                    {
                        Console.WriteLine("Слово введено не правильно, повторите его через " + Y + " дня(ей) ");
                        Thread.Sleep(Y * 1000);
                        Console.WriteLine("Введите слово: ");
                    }
                    goto RepeatWord;
                }
            }
            else
            {
                Console.WriteLine("Вы не ввели слово, которое хотите поторить!");
                goto Repeat;
            } 

            LableLast:
            Console.Write("Хотите повторить? yes/no ");
            string rep = Console.ReadLine();
            if (rep == null) goto LableLast;
            if (rep == "yes") goto Repeat;
            if (rep == "no") return;
        }
    }
}
