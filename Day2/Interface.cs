using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    interface INormalCal
    {
        //Public and Abstract

        int Add(int x, int y);
        int Sub(int x, int y);
	 Console.WriteLine("Mihir OP");
    }

    interface ISciCal
    {
        int Add(int a, int b);
        int Mul(int x, int y);
    }


    class Calculator: INormalCal,ISciCal
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x,int y)
        {
            return x - y;
        }

        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        class InterfaceEg
        {
            static void Main()
            {
                INormalCal ncal = new Calculator();
                Console.WriteLine("Addition of Normal Calculator: {0}", ncal.Add(5, 7));
                Console.WriteLine("Subtraction of Normal Calculator: {0}", ncal.Sub(95, 7));
                ISciCal scical = new Calculator();
                Console.WriteLine("Addition of Scientific Calculator: {0}", scical.Add(5, 7));
                Console.WriteLine("Subtraction of Scientific Calculator: {0}", scical.Mul(95, 7));

            }
        }

    }

}
