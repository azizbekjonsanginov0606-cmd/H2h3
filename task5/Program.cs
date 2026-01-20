List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);
List<int> oddNumbers = numbers.FindAll(n => n % 2 != 0);

Console.WriteLine("The filtered numbers are:");
foreach (int number in evenNumbers)
{
    Console.Write(" "+number);
}
Console.WriteLine();
foreach (int number in oddNumbers)
{
    Console.Write(" "+number);
}
Console.WriteLine();