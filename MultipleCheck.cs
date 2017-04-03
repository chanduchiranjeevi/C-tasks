
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MultipleCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count =0;
            int[] nums = new int[100];
            for (int i = 0; i <nums.Length; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < nums.Length; i++){
                if (nums[i] % 4 == 0){
                    Console.WriteLine(nums[i]);
                    count++;
                    continue;
            }
            else if (nums[i] % 6 == 0){
                Console.WriteLine(nums[i]);
                count++;
                continue;
                }
                
            }
        
        Console.WriteLine("count is " + count);
        }
    }
}