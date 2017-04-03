
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0:#,##0.##}", 1234567.89 ));
            }
    }
}