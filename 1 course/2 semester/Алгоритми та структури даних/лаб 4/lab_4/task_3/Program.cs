class Program
{

    static int Priority(string symbol)
    {
        switch (symbol)
        {
            case ")": return 0;
            case "(": return 1;
            case "-": return 2;
            case "+": return 2;
            case "/": return 3;
            case "*": return 3;
            case "^": return 4;
            case "sqrt": return 5;
            default: return 0;
        }
    }

    static List<string> Station(string expression)
    {
        Stack<string> stack = new();
        List<string> result = new();
        string[] symbolsArr = expression.Split(" ");

        for (int i = 0; i < symbolsArr.Length; i++)
        {
            if (float.TryParse(symbolsArr[i], out float num))
            {
                result.Add(symbolsArr[i]);
            }
            else if (symbolsArr[i] == "(")
            {
                stack.Push(symbolsArr[i]);
            }
            else if (symbolsArr[i] == ")")
            {
                string symbol = stack.Pop();
                while (symbol != "(")
                {
                    result.Add(symbol);
                    symbol = stack.Pop();
                }
            }
            else
            {
                if (stack.Count > 0)
                {
                    if (Priority(symbolsArr[i]) <= Priority(stack.Peek()))
                    {
                        result.Add(stack.Pop());
                    }
                }
                stack.Push(symbolsArr[i]);
            }
            Console.Write("Рядок: ");
            for (int j = 0; j < result.Count; j++)
            {
                Console.Write($"{result[j]} ");
            }
            Console.Write("\nСтек: ");
            foreach (Object obj in stack)
            {
                Console.Write($"{obj} ");
            }
            Console.Write("\n\n");
        }
        while (stack.Count > 0)
        {
            result.Add(stack.Pop());
        }
        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Stack<float> stack = new();
        Console.Write("Введіть вираз: ");
        string str = Console.ReadLine();
        List<string> expressionList = Station(str);
        float num1, num2;
        Console.Write($"Зворотній польський запис: ");
        for (int i = 0; i < expressionList.Count; i++)
        {
            Console.Write($"{expressionList[i]} ");
        }
        Console.Write("\n");
        for (int i = 0; i < expressionList.Count; i++)
        {
            if (float.TryParse(expressionList[i], out float num))
            {
                stack.Push(num);
            }
            else
            {
                switch (expressionList[i])
                {
                    case "+":
                        {
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num2 + num1);
                            break;
                        }
                    case "-":
                        {
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num2 - num1);
                            break;
                        }
                    case "*":
                        {
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num2 * num1);
                            break;
                        }
                    case "/":
                        {
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num2 / num1);
                            break;
                        }
                    case "^":
                        {
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push((float)Math.Pow(num2, num1));
                            break;
                        }
                    case "sqrt":
                        {
                            stack.Push((float)Math.Sqrt(stack.Pop()));
                            break;
                        }
                    default: break;

                }
            }
        }
        Console.WriteLine($"\nОбчислення {str} = {stack.Peek()}\n");
    }
}