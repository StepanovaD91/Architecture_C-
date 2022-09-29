using System;

namespace Refactoring
{
    internal class MaxEvenNumber : IArithmetic
    {
        public string MathOperation(int numericData)
        {
            int maxEvenNumber = 0;
            float checking;

            for (int i = 1; i < numericData; i++)
            {
                if(i % 2 == 0)
                {
                    try
                    {
                        checking = checked(maxEvenNumber = i);
                    }
                    catch(System.OverflowException error)
                    {
                        Console.WriteLine("\nПроизошла ошибка в расчетах\n");
                        return $"--->Ошибка - {error}\n";
                    }
                }            
            }

            return maxEvenNumber.ToString();
            
        }
    }
}