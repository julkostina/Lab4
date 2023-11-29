using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work4
{
    public class Operations
    {
        public Operations() { }
        public static int Add(int a, int b)
        {
            int res = 0;
            EventGenerator Generator = new EventGenerator();
            Generator.Overflowed += Show;
            if ( a > int.MaxValue - b ||  a < int.MinValue + b)
            {
                Generator.Checking(a, b, Operation.Addition);
            }
            else
            {
                res = a + b;
            }
            Generator.Overflowed -= Show;
            return res;
        }
        public static int Subtract(int a, int b)
        {
            int res = 0;
            EventGenerator Generator = new EventGenerator();
            Generator.Overflowed += Show;
            if (a > int.MaxValue + b || a < int.MinValue - b)
            {
                Generator.Checking(a, b, Operation.Subtracton);
            }
            else
            {
                res = a- b;
            }
            Generator.Overflowed -= Show;
            return res;

        }
        public static int Multiply(int a, int b)
        {
            int res = 0;
            EventGenerator Generator = new EventGenerator();
            Generator.Overflowed += Show;
            if (a > int.MaxValue * b || a < int.MinValue / b)
            {
                Generator.Checking(a, b, Operation.Multiplication);
            }
            else
            {
                res = a / b;
            }
            Generator.Overflowed -= Show;
            return res;
        }
        private static void Show(object sender, OverFlowedEventArgs e)
        {
            Console.WriteLine(e.Overflowing);
        }
    }
}
