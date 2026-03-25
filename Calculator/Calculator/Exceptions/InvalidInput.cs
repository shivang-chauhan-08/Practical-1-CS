using System;

class InvalidInput : Exception
{
    public InvalidInput(string msg) : base(msg) { }
}
