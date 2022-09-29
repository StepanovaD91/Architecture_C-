using System;

namespace Refactoring
{
    public class Count
    {
        private readonly IArithmetic mathOperation;

        public Count(IArithmetic mathOperation)
        {
            if(MathOperation == null)
            {
                throw new ArgumentNullException("mathOperation");
            }
            this.mathOperation = mathOperation;
        }

        public string Exclaim(int numericData)
        {
            return this.mathOperation.MathOperation(numericData).ToString();
        }
    }
}