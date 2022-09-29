using System;

namespace Refactoring
{
    internal class Factorial : IArithmetic
    {
        public string MathOperation(int numericData)
        {
            float checking;
            int factorial = 1;

            for (int i = 1; i < numericData; i++)
            {
                try
                {
                    checking = checked(factorial *= i);
                }
                catch(System.OverflowException error)
                {
                    Console.WriteLine("\nОшибка, слишком большое число\n");
                    return $"--->Ошибка - {error}\n";
                }
            }

            return factorial.ToString();
        }
    }
}