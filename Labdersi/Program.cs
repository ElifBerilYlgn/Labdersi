
Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.Write("Which city are you from? ");
string city = Console.ReadLine();

Console.WriteLine($"Name: {name}");
Console.WriteLine($"City: {city}");
Console.WriteLine("C# is fun");
Console.WriteLine($"Hello {name} from {city}, welcome to C#!");







Console.WriteLine();
Console.WriteLine();
Console.Write("first number: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("second number: ");
double number2 = double.Parse(Console.ReadLine());

Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
Console.WriteLine($"{number1} / {number2} = {number1 / number2}");









Console.WriteLine();
Console.WriteLine();
Console.Write("Enter student name: ");
string name1 = Console.ReadLine();

Console.Write("Enter midterm score: ");
double midterm = double.Parse(Console.ReadLine());

Console.Write("Enter final score: ");
double final = double.Parse(Console.ReadLine());

double average = midterm * 0.4 + final * 0.6;

Console.WriteLine($"{name1}, your average is {average:F2}");

if (final == 100)
{
    Console.WriteLine("Result: Perfect final");
}
if (average >= 50)
{
    Console.WriteLine("Result: Passed");
}
else
{
    Console.WriteLine("Result: Failed");
}









Console.WriteLine();
Console.WriteLine();
Console.Write("Enter a 3 digit number: ");
int number = int.Parse(Console.ReadLine());

int hundreds = number / 100;
int tens = (number / 10) % 10;
int units = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {units}");
Console.WriteLine($"Sum of digits: {hundreds + tens + units}");

if (number % 2 == 0)
{
    Console.WriteLine($"{number} number even");
}
else
{
    Console.WriteLine($"{number} number odd");
}

if (hundreds == units)
{
    Console.WriteLine("first and last digits are same");
}
else
{
    Console.WriteLine("first and last digits are different");
}