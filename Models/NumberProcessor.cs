using Interfeisai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisai.Models
{
    public class NumberProcessor : INumberProcessor
    {
        public void ProcessNumbers()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} yra dalijamas is 3 ir 5");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine($"{i} yra dalijamas tik is 3");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} yra dalijamas tik is 5");
                }
                else
                {
                    Console.WriteLine($"{i} nera dalijamas nei is 3, nei is 5");
                }
            }

        }


    }
}
