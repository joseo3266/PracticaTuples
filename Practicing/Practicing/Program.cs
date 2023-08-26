using System;
//tuple elemen names

/*(string Name, int Points, int Level) score = ("R2-D2", 12420, 15);
System.Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score: {score.Points} ");

(string Name, int, int) score = ("R2-D2", 12430, 15);
System.Console.WriteLine($"Name: {score.Name} Level: {score.Item3} Points: {score.Item2}");

var score = (Name: "R2-D2", Points: 12420, Level: 15);
Console.WriteLine($"Name: {score.Name}, Points: {score.Points}, Level: {score.Level}");

(string, int P, int L) score = (Name: "R2-D2", Points: 12421, Level: 13);
Console.WriteLine($"Name: {score.Item1}, Level: {score.L}, Points: {score.P}");


(string Name, int Points, int Level) GetScore() => ("R2-D2", 12430, 15);
var score = GetScore();
Console.WriteLine($"Name: {score.Name}, Points: {score.Points}, Level: {score.Level}");
*/


var a = (X: 2, Y: 4);
var b = (U: 2, V: 4);
Console.WriteLine(a == b);