using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string argInput)
        {
            double ConvertedNumber;

            bool isConvertedNumber = double.TryParse(argInput, out ConvertedNumber);

            if(!isConvertedNumber)
            {
                throw new ArgumentException("Expected a Numeric Value");
            }

            return ConvertedNumber;
        }
    }
}
