using System;

namespace MathSolverLibrary
{
    public class MathSolverExeption : Exception
    {
        public double[] Values { get; set; }
        public MathSolverExeption(string message)
                : base(message)
        { }
        public MathSolverExeption(string message,double[] args)
        : base(message)
        {
            Values = args;
        }
    }
}
