// See https://aka.ms/new-console-template for more information
using Practice;


var input = "";
//keep taking user input until user wants to exit
while (true)
{

    //Write console write to take user choice
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Reverse String");
    Console.WriteLine("2.IsPalindrome");
    Console.WriteLine("3.FindMax");
    Console.WriteLine("c.Clear");
    Console.WriteLine("9. Exit");
    var choice = Console.ReadLine();
    var result = "";
    //use switch case to call respective method based on user choice
    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter a String");
            input = Console.ReadLine();
            result = AlgorithmicQuestions.ReverseString(input); ;
            break;
        case "2":
            Console.WriteLine("Enter a String");
            input = Console.ReadLine();
            result = AlgorithmicQuestions.IsPalindrome(input).ToString();
            break;
        case "3":
            Console.WriteLine("Enter numbers separated by commas");
            input = Console.ReadLine();
            var numbers = input.Split(',').Select(int.Parse).ToArray();
            result = AlgorithmicQuestions.FindMax(numbers).ToString();
            break;
        case "c":
            Console.Clear();
            continue;
        case "9":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }






    Console.WriteLine($"Result {result}");
    Console.ReadKey();
}