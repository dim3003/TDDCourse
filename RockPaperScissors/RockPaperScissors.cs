namespace RockPaperScissors;

public partial class RockPaperScissors
{
    public Outcomes Play(PlayerMoves playerMove, PlayerMoves opponentMove)
    {
        if (playerMove == PlayerMoves.Paper)
        { 
            return Outcomes.PlayerWins;
        }
        return Outcomes.PlayerLoses;
    }
}
