using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work4
{
    public enum Operation
    {
        Addition, Subtracton, Multiplication
    }
    public delegate void StateHandler(object sender, OverFlowedEventArgs e);
    public class EventGenerator
    {
        public event StateHandler Overflowed;

        public void Checking(int a,int b, Operation operation)
        {
            if(Convert.ToString(operation) == "Addition")
            {

                    Overflowed(this, new OverFlowedEventArgs($"Overflow of discharge grid happened while adding {a} and {b}"));
                
            }
            else if (Convert.ToString(operation) == "Subtracton")
            {
                    Overflowed(this, new OverFlowedEventArgs($"Overflow of discharge grid happened while subtracting {a} and {b}"));
                
            }
            else if (Convert.ToString(operation) == "Multiplication")
            {

                    Overflowed(this, new OverFlowedEventArgs($"Overflow of discharge grid happened while multiplying {a} and {b}"));
                
            }
        }
    }
}
