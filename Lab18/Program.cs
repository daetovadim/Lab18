using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\tРабота с коллекциями");

            Console.Write("\n Введите строку для проверки: ");
            string checkStr = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < checkStr.Length; i++)
            {
                if (checkStr[i] == '{')
                {
                    brackets.Push('}');
                }
                else if (checkStr[i] == '[')
                {
                    brackets.Push(']');
                }
                else if (checkStr[i] == '(')
                {
                    brackets.Push(')');
                }

                if (checkStr[i] == brackets.Peek())
                    brackets.Pop();
            }
            
            if (brackets.Count == 0)
                Console.WriteLine("\n Скобки расставлены верно.");
            else
                Console.WriteLine("\n Скобки расставлены неправильно, попробуйте снова.");

            Console.ReadKey();
        }
    }
}
