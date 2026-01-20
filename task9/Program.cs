List<string> fruits = new List<string>();

// fruits.Add("Apple");
// fruits.Add("Banana");
// fruits.Add("Orange");
fruits.AddRange(["Apple","Banana","Orange"]);
Console.Write("Fruits list:");
foreach (string fruit in fruits)
{
    Console.Write(fruit+" ");
}
Console.WriteLine();