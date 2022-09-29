using System;

namespace Refactoring
{
    internal class Amount : IArithmetic
    {
        public string MathOperation(int numericData)
        {
            int amount = 0;
            float checking;

            for (int i = 1; i < numericData; i++)
            {
                try
                {
                    checking = checked(amount += i);
                }
                catch(System.OverflowException error)
                {
                    Console.WriteLine("\nОшибка, слишком большое число\n");
                    return $"--->Ошибка - {error}\n";
                }
            }

            return amount.ToString();
            
        }
    }
}