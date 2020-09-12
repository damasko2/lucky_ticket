using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luckyTicket
{
    class Ticket
    {
        private string _ticket;
        private int _num;

        private long job()
        {
            int num = 0;
            int num2 = 0;
            int remainder = 0;
            long symm = 0;

            if (_num%2==0)
            {
                for (int i = 0; i < _num/2; i++)
                {
                    num += Convert.ToInt32(_ticket[i]);
                }

                num2 = num / (_num / 2);
                remainder = num % (_num / 2);

                if (num%(_num/2)==0)
                {
                    char[] str = new char[_num + 1];
                    str[_num] = '\0';

                    for (int i = 0; i < _num/2; i++)
                    {
                        str[i] = Convert.ToChar(_ticket[i]);
                    }

                    for (int i = _num/2; i < _num; i++)
                    {
                        str[i] = Convert.ToChar(num2);
                    }

                    string str5 = new string(str);
                    symm = Convert.ToInt64(str5);
                }
                else
                {
                    char[] str = new char[_num + 2];
                    str[_num + 1] = '\0';

                    for (int i = 0; i < _num / 2; i++)
                    {
                        str[i] = Convert.ToChar(_ticket[i]);
                    }

                    for (int i = _num / 2; i < _num; i++)
                    {
                        str[i] = Convert.ToChar(num2);
                    }

                    str[_num] = (char)remainder;

                    for (int i = 0; i < str.Length; i++)
                    {
                        Console.WriteLine(str[i]);
                    }
                    Console.ReadKey();

                    string str5 = new string(str);
                    symm = Convert.ToInt64(str5);
                }
            }
            else
            {

            }

            return symm;
        }

        public Ticket(string ticket)
        {
            _ticket = ticket;
            _num = ticket.Length;
        }

        public void show()
        {
            long symm = job();

            Console.WriteLine(symm);
        }


    }
}
