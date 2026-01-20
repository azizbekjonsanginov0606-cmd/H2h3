List<int> randomNumbers = new List<int>();
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    randomNumbers.Add(random.Next(1, 101));
}

Console.WriteLine("Random numbers:");
foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}
