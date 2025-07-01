//Sorting e Searching in C#


// var numbers = new List<int> { 20, 1, 15, 66, 77};

//names = [..names, "David", "Andre"];// Using the spread operator to add elements

// Console.WriteLine($"I found 15 at index {numbers.IndexOf(15)}"); // Get the index of the number 15
// numbers.Sort(); // Sort the list in ascending order
// Console.WriteLine($"I found 15 at index {numbers.IndexOf(15)}"); // Get the index of the number 15


// foreach (var number in numbers)
// {
//     Console.WriteLine(number);

// }

//Console.WriteLine(names[^1]);//Last element


//LINQ


// Specify the data source.
List<int> scores = [97, 92, 81, 60];

//Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;


var scoreQuery2 = scores.Where(s => s > 80)
    .OrderByDescending(s => s);

List<int> myScores = scoreQuery.ToList();

foreach (int score in myScores)
{
    Console.WriteLine(score);
}

