using System;
using System.Linq;

namespace Refactoring
{
    public class Program
    {
        static void Main()
        {
            IArithmetic factorial = new Factorial();
            IArithmetic maxEvenNumber = new MaxEvenNumber();
            IArithmetic amount = new Amount();

            Console.WriteLine("Здравствуйте, Вас приветствует математическая программа");
            Console.Write(StringConstants.request);

            int intOperand;
            string operand = Console.ReadLine();
            while(!int.TryParse(operand, out intOperand))
            {
                if(operand == StringConstants.quit)
                {
                    return;
                }
                Console.WriteLine(StringConstants.request);
                operand = Console.ReadLine();
            }

            Console.WriteLine("Введите число \"1\" один, если хотите воспользоваться функцией - \"Факториал\"");
            Console.WriteLine("Введите число \"2\" два, если хотите воспользоваться функцией - \"Максимально четное число\"");
            Console.WriteLine("Введите число \"3\" три, если хотите воспользоваться функцией - \"Арифметическая прогрессия\"");

            int intOptionNumber;
            string optionNumber = Console.ReadLine();
            while (!int.TryParse(optionNumber, out intOptionNumber) && !Enumerable.Range(1, 3).Contains(intOptionNumber))
            {
                if(optionNumber == StringConstants.quit)
                {
                    return;
                }
                Console.WriteLine("Введите число от 1 до 3");
                optionNumber = Console.ReadLine();
            }

            switch (intOptionNumber)
            {
                case(int)UserAnswer.Factorial:
                    var choice1 = new Count(factorial);
                    Console.WriteLine($"Факториал числа {intOperand} равен: {choice1.Exclaim(intOperand)}");
                    break;
                case(int)UserAnswer.MaxEvenNumber:
                    var choice2 = new Count(maxEvenNumber);
                    Console.WriteLine($"Максимальное чётное числа {intOperand} равно: {choice2.Exclaim(intOperand)}");
                    break;
                case(int)UserAnswer.Amount:
                    var choice3 = new Count(Amount);
                    Console.WriteLine($"Арифметическая поргрессия числа {intOperand} равна: {choice3.Exclaim(intOperand)}");
                    break;    
            }
        }
    }
}