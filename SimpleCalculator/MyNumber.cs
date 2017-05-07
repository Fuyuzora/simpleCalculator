using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MyNumber
    {
        public string Operator;
        public string sign = "+";
        public double value;
        public string bracket;

        public MyNumber() { }
        
        public MyNumber(double Value, string OPERATOR)
        {
            value = Value;
            Operator = OPERATOR;
        }
    }
}
