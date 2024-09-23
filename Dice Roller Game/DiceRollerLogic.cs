using System;
namespace Dice_Roller_Game;

public static class DiceRollerLogic
{
    private static readonly Random Dice = new Random();

    public static int RollForShooter()
    {
        int roll = Dice.Next(1, 7);
        return roll;
    }

    public static int RollTwoDice()
    {
        int roll1 = Dice.Next(1,7);
        int roll2 = Dice.Next(1, 7);
        return roll1 + roll2;
    }
}
