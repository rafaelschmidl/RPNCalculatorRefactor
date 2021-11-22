using System;
using System.Text;

namespace RPNCalculatorRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var controller = new Controller(calculator);
            var ui = new UI(controller);



            ui.Run();


            /// TODO:::: fixa char till string --- fixa illigal command --- wrong foramt



        }
    }
}
