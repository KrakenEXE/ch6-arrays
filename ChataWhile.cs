using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAWhile
{
    class ChataWhile
    {
        static void Main(string[] args)
        {
            int[] areaCode = { 262, 414, 608, 715, 815, 920 };
            double[] minRates = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            int givenAreaCode;
            double amountForCall = 0;
            bool isVaildItem = false;
            double phoneCallLength;
            int x;
            double phoneCallPrice;

            WriteLine("What is your area code? Options 262, 414, 608, 715, 815, 920 >> ");
            givenAreaCode = Convert.ToInt32(Console.ReadLine());

            WriteLine("How long is the call? >> ");
            phoneCallLength = Convert.ToDouble(Console.ReadLine());

            x = 0;

            while (x < areaCode.Length && givenAreaCode != areaCode[x])
                ++x;
            if (x != areaCode.Length)
            {
                isVaildItem = true;
                amountForCall = minRates[x];
            }
            if (isVaildItem)
            {
                WriteLine("area code {0} would call {1} a minute. Thank you!", givenAreaCode, amountForCall.ToString("C"));
            }
            else
                WriteLine("No such item as {0}", givenAreaCode);

            phoneCallPrice = amountForCall * phoneCallLength;

            WriteLine("The total cost would be {0}", phoneCallPrice.ToString("C"));
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
