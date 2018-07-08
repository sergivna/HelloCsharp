using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            GetCont(ref a);
            if (a < 0 || a == 0)
            {
                Console.WriteLine("<<<WRONG PARAMETR>>>");
                Console.ReadKey();
                return;
            }
            ProcessPoint(a);
            Console.ReadKey();
        }


        public static void GetCont(ref int a)
        {
            
            Console.WriteLine("ВВедіть параметр а (а>0)");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a == 0) a = -1;
         }

         public  static void GetPoint (ref double x,ref double y)
        {
            Console.WriteLine("Введіть x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть y:");
            y = Convert.ToDouble(Console.ReadLine());
        }

         public static void OutCont( int a)
        {
            Console.WriteLine($"Parametr is [{a}]");
        }
        
        public static void OutPoint(double x, double y)
        {
            Console.WriteLine($"Point is ({x};{y})");
        }

        public static int  WherePoint (int a, double x, double y)
        {
            if (x < 0) x = -x;
            if (y < 0) y = -y;
            if ((-a * x - a * y + a * a) < 0 ) return -1;
            if ((-a * x - a * y + a * a == 0 && y <= a) || (x <= a && y == 0)) return 0;
            else return 1;
            
        }

        public static void ProcessPoint ( int a)
        {
            double x = 0, y = 0;
            GetPoint(ref x,ref y);
            OutCont(a);
            OutPoint(x, y);
           
            if (WherePoint(a,x,y)==-1)
                Console.WriteLine("OUT_C");
            if (WherePoint(a, x, y) == 0)
                Console.WriteLine("ON_C");
            if (WherePoint(a, x, y) == 1)
                Console.WriteLine("IN_C");
        }

        
    }
}
