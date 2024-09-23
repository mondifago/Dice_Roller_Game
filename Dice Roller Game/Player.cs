using System;
namespace Dice_Roller_Game;

public class Player
{
    public string UserName { get; set; }
    public int PlayerId { get; set; }
    public int PlayerTurn { get; set; }
    
    public Player(string userName, int playerId, int playerTurn)
    {
        UserName = userName;
        PlayerId = playerId;
        PlayerTurn = playerTurn;
    }

    // Default constructor
    public Player()
    {
    }
}
