﻿using System;
namespace Dice_Roller_Game;

class Program
{
    static void Main(string[] args)
    {
        Random dice = new Random();
        Console.WriteLine("*************************** Welcome To Rolling Dice ************************\n");
        Console.WriteLine("GAME RULES" +
            "\n1, If any two dice you roll result in the same value, you get two bonus points for rolling doubles." +
            "\n2, If all three dice you roll result in the same value, you get six bonus points for rolling triples." +
            "\n3, If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.\n");
        int roll1 = dice.Next(1,7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a CAR!!!!!");
            return;
        }
        if (total >= 10)
        {
            Console.WriteLine("You win a new Laptop");
            return;
        }
        if (total == 7)
        {
            Console.WriteLine("You win a Trip");
        }
        if (!(total>=16) || !(total >= 10)|| (total != 7))
        {
            Console.WriteLine("You win a kitten!");
        }

        Console.WriteLine("Grand Total = " + total);
    }
}

