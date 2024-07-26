using Interfeisai.Contracts;
using Interfeisai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisai.Service
{
    public class NumberService
    {
        public void OnStart()
        {
            INumberPrinter numberPrinter = new NumberPrinter();
            Console.WriteLine("Kaip veikia NumberPrinter:");
            numberPrinter.PrintNumbers();

            INumberProcessor numberProcessor = new NumberProcessor();
            Console.WriteLine("Kaip veikia NumberProcesor:");
            numberProcessor.ProcessNumbers();

            IEvenOddChecker evenOddChecker = new EvenOddChecker();
            Console.WriteLine("Kaip veikia EvenOddChecker:");
            evenOddChecker.CheckEvenOdd();

        }

    }
}
