using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        bool insideBrackets = false;
        char operation = '+';
        char operationBeforeBrackets = '+';
        decimal number;
        decimal result = 0;
        decimal resultBeforeBrackets = 0;
        decimal resultInsideBrackets = 0;
        StringBuilder numberString = new StringBuilder();
        numberString.Append('0');
        string expression = Console.ReadLine();
        for (int i = 0; i < expression.Length; i++)
        {
            if ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.') // digit
            {
                numberString.Append(expression[i]);
            }
            else if (expression[i] == '(')
            {
                insideBrackets = true;
                resultBeforeBrackets = result;
                resultInsideBrackets = 0;
                operationBeforeBrackets = operation;
                operation = '+';
            }
            else
            {
                number = decimal.Parse(numberString.ToString());
                numberString.Clear();
                numberString.Append('0');
                if (!insideBrackets)
                {
                    switch (operation)
                    {
                        case '+':
                            result += number;
                            break;
                        case '-':
                            result -= number;
                            break;
                        case '*':
                            result *= number;
                            break;
                        case '%':
                            result %= number;
                            break;
                    }
                }
                else //  inside Brackets
                {
                    switch (operation)
                    {
                        case '+':
                            resultInsideBrackets += number;
                            break;
                        case '-':
                            resultInsideBrackets -= number;
                            break;
                        case '*':
                            resultInsideBrackets *= number;
                            break;
                        case '%':
                            resultInsideBrackets %= number;
                            break;
                        case ')':
                            switch (operationBeforeBrackets)
                            {
                                case '+':
                                    result = resultBeforeBrackets + resultInsideBrackets;
                                    break;
                                case '-':
                                    result = resultBeforeBrackets - resultInsideBrackets;
                                    break;
                                case '*':
                                    result = resultBeforeBrackets * resultInsideBrackets;
                                    break;
                                case '%':
                                    result = resultBeforeBrackets % resultInsideBrackets;
                                    break;
                            }
                            insideBrackets = false;
                            break;
                    }
                }
                operation = expression[i];
            }
        }
        Console.WriteLine("{0:F3}", result);
    }
}

