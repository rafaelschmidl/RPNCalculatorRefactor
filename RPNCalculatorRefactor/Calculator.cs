using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPNCalculatorRefactor
{
    public class Calculator : ICalculator
    {
        private readonly Stack<decimal> values = new();

        public void InputValue(decimal value)
        {
            values.Push(Convert.ToDecimal(value));
        }

        public void Clear()
        {
            values.Clear();
        }

        public void Addition()
        {
            values.Push(values.Pop() + values.Pop());
        }

        public void Subtraction()
        {
            decimal value = values.Pop();
            values.Push(values.Pop() - value);
        }

        public void Mutiplication()
        {
            values.Push(values.Pop() * values.Pop());
        }

        public void Division()
        {
            decimal value = values.Pop();
            values.Push(values.Pop() / value);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append('[');
            foreach (var (value, index) in values.Select((value, index) => (value, index)))
            {
                sb.Append(Math.Round(value, 9));
                if (index < values.Count - 1) sb.Append(", ");
            }
            return sb.Append(']').ToString();
        }
    }
}
