using Interfeisai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisai.Models
{
    public class NumberPrinter : INumberPrinter
    {
        public void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
        }

    }
}
