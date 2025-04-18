using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Game game = new Game();
            Console.WriteLine("Welcome to Elevens!");

            while (true)
            {
                List<Card> faceUp = game.GetBoard().GetFaceUpCards();
                Console.WriteLine("\nCurrent Cards:");
                for (int i = 0; i < faceUp.Count; i++)
                {
                    Console.WriteLine(i + ": " + faceUp[i]);
                }

                Console.WriteLine("Select card indexes separated by spaces (e.g., 0 1): ");
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                List<Card> selected = new List<Card>();
                foreach (var t in tokens)
                {
                    if (int.TryParse(t, out int index) && index >= 0 && index < faceUp.Count)
                    {
                        selected.Add(faceUp[index]);
                    }
                }

                bool valid = game.CheckMove(selected);
                if (valid)
                {
                    game.PlayMove(selected);
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }

                if (game.IsWin())
                {
                    Console.WriteLine("You win! All cards removed.");
                    break;
                }
                if (game.IsLoss())
                {
                    Console.WriteLine("No more valid moves. You lose.");
                    break;
                }
            }

            Console.WriteLine("Play again? (y/n): ");
            string again = Console.ReadLine().ToLower();
            if (again != "y")
            {
                break;
            }
        }
    }
}
