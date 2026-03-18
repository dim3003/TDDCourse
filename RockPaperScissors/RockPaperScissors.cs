namespace RockPaperScissors;

public class RockPaperScissors
{
    private static readonly Outcomes[,] ResultsMatrix =
    {
        //                Rock                    Paper                   Scissors
        /* Rock     */ {  Outcomes.Tie,           Outcomes.PlayerLoses,   Outcomes.PlayerWins  },
        /* Paper    */ {  Outcomes.PlayerWins,    Outcomes.Tie,           Outcomes.PlayerLoses },
        /* Scissors */ {  Outcomes.PlayerLoses,   Outcomes.PlayerWins,    Outcomes.Tie         },
    };

    public Outcomes Play(PlayerMoves playerMove, PlayerMoves opponentMove)
    {
        return ResultsMatrix[(int)playerMove, (int)opponentMove];
    }
}