using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    class Controller : IController
    {
        private readonly ICalculator _calculator;

        private readonly Dictionary<char, Action> options = new();

        public Controller(ICalculator calculator)
        {
            _calculator = calculator;
            options.Add('+', () => _calculator.Addition());
            options.Add('-', () => _calculator.Subtraction());
            options.Add('*', () => _calculator.Mutiplication());
            options.Add('/', () => _calculator.Division());
            options.Add('c', () => _calculator.Clear());
            options.Add('q', () => Environment.Exit(0));
        }

        public void InputValue(decimal value)
        {
            _calculator.InputValue(value);
        }

        public bool IsOption(char option)
        {
            return options.ContainsKey(option);
        }

        public void InvokeOption(char option)
        {
            options[option].Invoke();
        }

        public string Output()
        {
            return _calculator.ToString();
        }
    }
}
