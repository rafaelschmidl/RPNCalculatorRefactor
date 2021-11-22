namespace RPNCalculatorRefactor
{
    internal interface IController
    {
        void InputValue(decimal value);
        void InvokeOption(char option);
        bool IsOption(char option);
        string Output();
    }
}