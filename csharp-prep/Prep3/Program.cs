using System;

class Program
{
    static void Main(string[] args)
    {
        int guessing = 1;
        int number = 0;

        Console.Write("What is the  magic number? ");
        string magic = Console.ReadLine();
        number = int.Parse(magic);

        while (guessing != number)
        {  

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessing = int.Parse(guess);


            if (guessing < number)
                Console.WriteLine("Higher ");
            else if (guessing > number)
                Console.WriteLine("Lower");
        
        }
        Console.WriteLine("You got it!! ");
    }
}