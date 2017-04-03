
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoundOff
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float num =5.6789F;
            Console.WriteLine("original number is 5.6789" +", number with 2 decimal places is " + Decimal.Round((decimal)num, 2));
        }
    }
}