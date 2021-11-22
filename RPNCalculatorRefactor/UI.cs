using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    class UI
    {
        private readonly Controller _controller;

        public UI(Controller controller)
        {
            _controller = controller;
        }

        public static void OptionsMenu()
        {
            StringBuilder sb = new();
            sb.Append("┌──────────────────── OPTIONS ────────────────────┐\n");
            sb.Append("│ Input a number to add it to the rpm-calculator. │\n");
            sb.Append("│ Calculator operands: '+', '-', '*', '/'.        │\n");
            sb.Append("│ Press 'c' to clear.                             │\n");
            sb.Append("│ Press 'q' to quit.                              │\n");
            sb.Append("│ Press 'Enter' to confirm action.                │\n");
            sb.Append("└─────────────────────────────────────────────────┘\n");
            Console.WriteLine(sb.ToString());
        }

        public void Input()
        {
            var input = Console.ReadLine().Trim();
            if (input.All(char.IsNumber)) _controller.InputValue(decimal.Parse(input));
            else if (input.Length == 1 && _controller.IsOption(char.Parse(input))) _controller.InvokeOption(char.Parse(input));
            else Console.WriteLine("Invalid option...");
        }

        public void Output()
        {
            Console.WriteLine(_controller.Output());
        }

        public void Run()
        {
            OptionsMenu();
            while (true)
            {
                Output();
                Input();
            }
        }
    }
}
