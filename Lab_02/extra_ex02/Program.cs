using System;

namespace extra_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tries = 10, guess;
            int correct = rand.Next(0, 11); // 0 - 10
            Console.Write("Guess the number: ");
            while(tries != 0)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == correct)
                {
                    Console.Write("Correct");
                    break;
                }
                else
                {
                    if (guess > correct)
                    {
                        Console.Write($"{guess} > the number\n");
                    }
                    else if(guess < correct)
                    {
                        Console.Write($"{guess} < the number\n");
                    }
                }
                tries--;
            }
            if (tries == 0)
            {
                Console.Write($"You lost. magic num was {correct}");
            }
        }
    }
}
