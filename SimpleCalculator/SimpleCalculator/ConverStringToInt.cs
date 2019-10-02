using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class ConverStringToInt
    {
        public int Convert(string input)
        {
            try
            {
                int convertToNumber;

                bool isConvertToNumber = int.TryParse(input, out convertToNumber);

                if (!isConvertToNumber)
                {
                    throw new Exception("Conversion was not successful !"); //unhandle exception
                }

                return convertToNumber;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
