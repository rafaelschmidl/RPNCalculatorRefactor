namespace RPNCalculatorRefactor
{
    internal interface ICalculator
    {
        void Addition();
        void Clear();
        void Division();
        void InputValue(decimal value);
        void Mutiplication();
        void Subtraction();
        string ToString();
    }
}