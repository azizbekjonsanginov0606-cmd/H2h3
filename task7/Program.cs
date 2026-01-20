List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };

numbers4.Remove(3);

Console.WriteLine("List after removing element:");
foreach (int number in numbers4)
{
    Console.WriteLine(number);
}
