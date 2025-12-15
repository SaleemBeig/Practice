// See https://aka.ms/new-console-template for more information
using Practice;

Console.WriteLine("Enter a String");
var input= Console.ReadLine();

//Write console write to take user choice

var result=AlgorithmicQuestions.ReverseString(input); ;
Console.WriteLine($"Result {result}");
Console.ReadKey();