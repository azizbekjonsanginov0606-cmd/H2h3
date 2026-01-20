// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
List<string> words = new List<string> { "hello", "world", "!" };

string concat = string.Join(" ", words);

Console.WriteLine("The concatenated string is:" + concat);
