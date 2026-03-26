using System;

namespace Calculator.Interface
{
    public interface ICalculatorOperations
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        double Div(int a, int b);
    }
}
