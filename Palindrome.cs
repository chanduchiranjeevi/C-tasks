using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalind
{
    class Program
    {
        public static void Main(string[] args)
        {
        int check = 1;
            int i = 0;
            Console.WriteLine("Enter string to check");
            String str = Console.ReadLine();
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                    check = 0;
                i++;
                j--;
            }
            if (check == 1)
                Console.WriteLine("Palindrome");
            else Console.WriteLine("Not Palindrome");

        }
    }
}
