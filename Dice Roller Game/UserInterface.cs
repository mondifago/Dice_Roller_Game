using System;
namespace Dice_Roller_Game;

public static class UserInterface
{

    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("*************************** Welcome To Street Dice Roller Game ************************\n");
        Console.WriteLine("Please select start on the menu and register your names");
    }

    
    
    
   /* Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        
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
        
    }*/
    
}