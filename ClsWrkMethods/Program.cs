using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkMethods
{
   public class Program
    {
        static void Main(string[] args)
        {
            // By Value Parameter.........
            int a = 2;
            int returnValue = ByValue(a);
            Console.WriteLine(returnValue);
            Console.WriteLine(a);

            // By Reference parameter 

            int c = 2;
            int returnValue1 = ByRef(ref c);
            Console.WriteLine(returnValue1);
            Console.WriteLine(c);

            int b = 2;
            int returnValue2 = ByOut(out b);
            Console.WriteLine(returnValue2);
            Console.WriteLine(b);


            Console.ReadKey();
        }

         static int ByValue(int x , int y= 4)
        {
             x = 6;
            return x * y;
        }

        static int ByRef( ref int x, int y = 4)
        {
            x = 6;
            return x * y;
        }
        static int ByOut(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }


    }
}
