Console.WriteLine("Hello, opp!");

var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

List<Person> people = [p1];

Console.WriteLine($"First person: {p1.First} {p1.Last}, born on {p1.Birthday}");

public class Person(string firstName, string lastName, DateOnly birthDate)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthDate;


};