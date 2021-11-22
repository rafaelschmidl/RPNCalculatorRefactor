using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorRefactor;
using System.Collections.Generic;

namespace RPNCalculatorRefactorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator calculator = new();


        [TestMethod]
        public void InputValueTest()
        {
            calculator.InputValue(123);
            calculator.InputValue(3.14159m);
            calculator.InputValue(999999999999999999999999m);
            Assert.AreEqual("[999999999999999999999999, 3.14159, 123]", calculator.ToString());
        }

        [TestMethod]
        public void ClearTest()
        {
            calculator.InputValue(123);
            calculator.Clear();
            Assert.AreEqual("[]", calculator.ToString());
        }


    }
}