using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_228
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AY = new ArrayList() {1,6,9,10 };
            ArrayList BE = new ArrayList() {2,3,5,11,12 };

            // перебор значений
            foreach (object o in AY)
            {
                Console.Write(o+"\t");
            }
            Console.WriteLine();
            // перебор значений
            foreach (object o in BE)
            {
                Console.Write(o + "\t");
            }
            Console.Clear();
            Test.FunkOne(AY, BE);
            
        }
    }
}
