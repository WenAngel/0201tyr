using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterVacation01
{
    class Program
    {
        static void Main(string[] args)
        {
            int all=0;
            int fir = 0;
            int end = 1;
         
            for (all = 0; all <= 1836311903; all ++)
            {

                all = fir + end;
                fir = end;
                end = all;

                Console.WriteLine(all);
            }
            Console.ReadLine();
        }
    }
}
