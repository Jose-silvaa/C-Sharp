var names = new string[] { "Alice", "Bob", "Charlie" };

names = [..names, "David", "Andre"];// Using the spread operator to add elements

foreach (var name in names)
{
    Console.WriteLine(name);

}

Console.WriteLine(names[^1]);//Last element

