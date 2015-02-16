//Write a program that calculates the value of given arithmetical expression.
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities): (, )
//Examples:

//input	output
//(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)	  =         ~10.6
//pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) =	~21.22

namespace ArithmeticalExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MathCalculator
    {
        public static List<char> operators = new List<char>() { '+', '-', '*', '/', '%' };

        public static List<char> brackets = new List<char>() { '(', ')' };

        public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

        public static List<string> SeparateTokens(string input)
        {
            var result = new List<string>();
            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                    if (i == input.Length - 1)
                    {
                        result.Add(number.ToString());
                        number.Clear();
                    }
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;

                }
                else if (brackets.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (operators.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid input expression !");
                }
            }
            return result;
        }

        public static int Precedence(string arithmeticOperator)
        {
            if (arithmeticOperator == "+" || arithmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queque = new Queue<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;
                if (double.TryParse(currentToken, out number))
                {
                    queque.Enqueue(currentToken);
                }
                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets or function separator!");
                    }
                    while (stack.Peek() != "(")
                    {
                        queque.Enqueue(stack.Pop());
                    }
                }
                else if (operators.Contains(currentToken[0]))
                {
                    while (stack.Count != 0 && operators.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queque.Enqueue(stack.Pop());
                    }
                    stack.Push(currentToken);
                }
                else if (currentToken == "(")
                {
                    stack.Push("(");
                }
                else if (currentToken == ")")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid brackets");
                    }
                    while (stack.Peek() != "(")
                    {
                        queque.Enqueue(stack.Pop());
                    }
                    stack.Pop();
                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queque.Enqueue(stack.Pop());
                    }
                }
            }
            while (stack.Count != 0)
            {
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid brackets position! ");
                }
                queque.Enqueue(stack.Pop());
            }

            return queque;
        }

        public static double FinalResultFromRPN(Queue<string> queqe)
        {
            Stack<double> stack = new Stack<double>();

            while (queqe.Count != 0)
            {
                string currentToken = queqe.Dequeue();
                double number;
                if (double.TryParse(currentToken, out number))
                {
                    stack.Push(number);
                }
                else if (operators.Contains(currentToken[0]) || functions.Contains(currentToken))
                {
                    if (currentToken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if (currentToken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentToken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue * secondValue);
                    }
                    else if (currentToken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentToken == "%")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue % firstValue);
                    }
                    else if (currentToken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    if (currentToken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();
                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentToken == "ln")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();


                        stack.Push(Math.Log(value));
                    }
                }
            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalin expression");
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the expression:\n");
            string input = Console.ReadLine().Trim();
            string trimmedInput = input.Replace(" ", string.Empty);

            var separetedTokens = SeparateTokens(trimmedInput);
            var reversePolishNotation = ConvertToReversePolishNotation(separetedTokens);
            var finalResult = FinalResultFromRPN(reversePolishNotation);
            Console.WriteLine("\nThe result is:   ~ {0:F2}",finalResult);
        }
    }
}
