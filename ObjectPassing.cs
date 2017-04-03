using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plots = new int[4] { 3, 0, 0, 3 };
            int[] retrunarr = Closer(plots);
            Console.WriteLine(retrunarr[0] + " " + retrunarr[1] + " " + retrunarr[2] + " " + retrunarr[3]);
        }

        public static int[] Closer(int[] point)
        {

            int x1 = point[0];
            int y1 = point[1];
            int x2 = point[2];
            int y2 = point[3];

            Boolean X = true;
            Boolean Y = true;

            if (x1 > x2) { X = true; }     // if x1>x2 set to true
            if (y1 > y2) { Y = true; }    // if y1>y2 set to true 

            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("\n enter different coordinates for each object");
            }

            if (x1 == x2)    // x1==x2 and y1 != y2
            {
                if (Y)
                {
                    y1--;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;
                }
                else
                {
                    y1++;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;
                }
            }
            if (y1 == y2)
            {
                if (X)
                {
                    x1--;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;
                }
                else
                {
                    x1++;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;


                }
            }


            //0,3 3,0 #1
            if (X)
            {
                if (Y)
                {
                    x1--;
                    y1++;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;

                }
                else
                {
                    x1--;
                    y1++;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;

                }

            }
            else
            {
                if (Y)
                {
                    x1++;
                    y1--;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;

                }
                else
                {
                    x1++;
                    y1++;
                    int[] result = new int[4] { x1, y1, x2, y2 };
                    return result;
                }
            }
        }
    }
}
