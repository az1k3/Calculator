double num1, num2, result;
string? value;

while (true)
{
    Console.Write("Enter first number: ");
    string? firstNumberParse = Console.ReadLine();

    if (!double.TryParse(firstNumberParse, out num1))
    {
        Console.WriteLine($"'{firstNumberParse}' is not a number, please try again");
        continue; 
    }

    break; 
}

while (true)
{
    Console.Write("Enter second number: ");
    string? secondNumberParse = Console.ReadLine();

    if (!double.TryParse(secondNumberParse, out num2))
    {
        Console.WriteLine($"'{secondNumberParse}' is not a number, please try again");
        continue; 
    }

    break; 
}


do
{
    Console.Write("Please choose an operation for these numbers (+, -, *, /) : ");

    Calculator calculator = new Calculator();

    switch (Console.ReadLine())
    {
        case "+":
            result = calculator.Add(num1, num2);
            Helper.ShowResult(num1, num2, result, '+');
            break;
        case "-":
            result = calculator.Substract(num1, num2);
            Helper.ShowResult(num1, num2, result, '-');
            break;
        case "*":
            result = calculator.Multiply(num1, num2);
            Helper.ShowResult(num1, num2, result, '*');
            break;
        case "/":
            result = calculator.Divide(num1, num2);
            Helper.ShowResult(num1, num2, result, '/');
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }

    Console.Write("Do you want to continue(y/exit):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");


public static class Helper
{
    public static void ShowResult(double first, double second, double result, char operation)
    {
        Console.WriteLine($"Your result: {first} {operation} {second} = {result}");
    }
}

public class Calculator
{
    public double Add(double first, double second)
    {
        double sum = first + second;
        return sum;
    }
    public double Substract(double first, double second)
    {
        double substract = first - second;
        return substract;
    }
    public double Multiply(double first, double second)
    {
        double multiply = first * second;
        return multiply;
    }
    public double Divide(double first, double second)
    {
        double divide = first / second;
        return divide;
    }
}


