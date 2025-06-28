// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "Maria";

firstFriend = firstFriend.Trim();
string secondFriend = "Jose";

string friends = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Maria", "Ana"));
Console.WriteLine(friends.Contains("Maria"));

Console.WriteLine(friends.Length);

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);