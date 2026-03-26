using System;

namespace Calculator.Exceptions
{
    class InvalidInput : Exception
    {
        public InvalidInput(string msg) : base(msg) { }
    }
}
