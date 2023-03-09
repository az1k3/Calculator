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

    // Use a switch statement to do the math.
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            break;
        case "-":
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            break;
        case "*":
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            break;
        case "/":
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }

    Console.Write("Do you want to continue(y/n/exit):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");

