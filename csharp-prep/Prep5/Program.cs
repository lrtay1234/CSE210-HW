using System;

class Program
{
    static void Main(string[] args)
    {
        // this will print out the welcome
        DisplayWelcomeMessage();
        // this will get the users name and favorite number and store the info
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // this will mathmatically square the users favorite number
        int squaredNumber = SquareNumber(userNumber);
        // this will displpay the entire program from the info it collected from the other functions
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}