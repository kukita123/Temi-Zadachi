using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Условие:
Напишете Компилатор с инструкции, който получава произволен брой инструкции.
Програмата трябва да анализира инструкциите, да ги изпълни и изведе резултата. Трябва да
бъде поддържан следният набор от инструкции:
● INC <операнд1> - увеличава операнд с 1
● DEC <операнд1> - понижава операнд с 1
● ADD <операнд1> <операнд2> - дава сбор на двата операнда
● MLA <операнд1> <операнд2> - дава произведението на двата операнда
● END – край на въвеждането
Изход:
Резултатът на всяка инструкция трябва да бъде отпечатан на отделен ред на конзолата
Ограничения:
Операндите ще са валидни числа от [−2 147 483 648 … 2 147 483 647].


 */
namespace Tema10_Zadacha
{
    public class Instructions
    {
        public long Execute(string command)
        {
            
            string[] codeArgs = command.Split(' ');
            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result =operandOne * operandTwo;
                        break;
                    }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instruction = new Instructions();
            string code = Console.ReadLine();
            while (code != "END")
            {
                Console.WriteLine(instruction.Execute(code));
                code = Console.ReadLine();
            }
        }
    }
}
