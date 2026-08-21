using System.Net.Cache;
using System.Transactions;

Console.Write("Enter the Name :- ");
string Name = Console.ReadLine();

Console.Write("Enter the Age :- ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"my Name is {Name} and age is {age}");


Console.WriteLine(1.ToString("D3")); // before the start a number Add a 0 using ToString 
