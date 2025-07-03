Console.WriteLine("Hello, opp!");

var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

p1.Pets.Add(new Dog("Whiskers"));

List<Person> people = [p1];


foreach (var person in people)
{
    Console.WriteLine($"{person.First} {person.Last} was born on {person.Birthday}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"  {pet} says {pet.MakeNoise()}");
    }
}

public class Person(string firstName, string lastName, DateOnly birthDate)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthDate;

    public List<Pet> Pets { get; } = new();


};

public abstract class Pet(string firstName) {
    public string First { get; } = firstName;
    public abstract string MakeNoise();
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Meow!";

}

public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Woof!";

}