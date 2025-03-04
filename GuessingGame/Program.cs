using System.Collections.Concurrent;

namespace GuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a number between 1 and 20");
        Random rnd = new Random();
        int answer = rnd.Next(1, 20);
        int guess = 0;

        while (guess != answer){
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > answer){
                Console.WriteLine("Too high!");
            }
            else if (guess < answer){
                Console.WriteLine("Too low!");
            }
            else {
                Console.WriteLine($"Congrats! The answer was {answer}");
            } 
        }
    }
}
