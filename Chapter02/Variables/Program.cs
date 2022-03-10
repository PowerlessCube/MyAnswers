using System.IO;
using System.Xml;

object height = 1.88;
object name = "Amir";
dynamic anotherName = "Ahmed";
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length;
int length = anotherName.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

// var population = 66_000_000;
// var weight = 1.88;
// var price = 4.95M;
// var fruit = "Apples";
// var letter = 'Z';
// var happy = true;

// var xml1 = new XmlDocument();
// XmlDocument XMl2 = new XmlDocument();

// var file1 = File.CreateText(@"C:\something.text");
// StreamWriter file2 = File.CreateText(@"C:\something.txt");

// XmlDocument xml3 = new();

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

