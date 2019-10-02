using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringIntoDouble()
        {
            string inputNumber = "5";

            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);

            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inputNumber = "*";

            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);
            
        }
    }
}
