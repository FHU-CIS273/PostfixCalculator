using System;
using System.Collections.Generic;

namespace PostfixCalculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Evaluate(string postfixExpression)
        {
            Stack<double> stack = new Stack<double>();

            string[] tokens = postfixExpression.Split();

            foreach( var token in tokens)
            {
                if (IsDouble(token))
                {
                    stack.Push(double.Parse(token));
                }

                // if token is an operand
                // do something else

            }

            return 0.0;
        }

        private bool IsDouble(string s)
        {
            double result;

            bool isDouble = double.TryParse(s, out result);
          
            return isDouble;
        }
    }
}
