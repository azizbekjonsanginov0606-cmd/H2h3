List<bool> values = new List<bool> { true, true, true };

bool allTrue =values.All(v => v == true);

Console.WriteLine("Are all the values in the list true? " + allTrue);
