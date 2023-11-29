using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab_work4
{
    public class OverFlowedEventArgs
    {
        string Message { get;set; }
        public OverFlowedEventArgs(string message)
        {
            Message = message;
        }
        public string Overflowing { get {  return Message; } }
    }   
}
