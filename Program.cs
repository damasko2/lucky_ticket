using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket;
            long num;

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите номер билета:");
                        ticket = Console.ReadLine();
                        num = Convert.ToInt64(ticket);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nНеверный формат ввода. Введите число действительного типа");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Ticket tick = new Ticket(ticket);
                tick.show();

            }

        }
    }
}
