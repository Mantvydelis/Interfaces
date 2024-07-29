using Interfeisai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisai.Models
{
    public class EvenOddChecker : IEvenOddChecker
    {
        public void CheckEvenOdd()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine($"{i} skaicius yra lyginis");
                }
                else
                {
                    Console.WriteLine($"{i} skaicius yra nelyginis");
                }


            }


        }


    }
}
