using System;

namespace RefactortingTennisGame2
{
    public class TennisGameImpl : ITennisGame
    {
        private Player player1;
        private Player player2;

        public TennisGameImpl(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if (HasWinner())
            {
                return $"Win for {Winner().Name}";
            }
            
            if (player1.Equals(player2))
            {
                return player1.MatchPoint() ? "Deuce" : $"{player1.Result}-All";
            }

            if (!player1.Equals(player2))
            {
                return Winner().WinPoint()
                    ? Loser().MatchPoint() ? 
                        $"Advantage {Winner().Name}"
                        : ""
                    : $"{player1.Result}-{player2.Result}";
            }
            return "";
        }

        private bool HasWinner()
        {
            return Winner().WinPoint() && Math.Abs(player1.Point - player2.Point) >= 2;
        }

        private Player Winner()
        {
            return player1.Point > player2.Point ? player1 : player2;
        }

        private Player Loser()
        {
            return player1.Point > player2.Point ? player2 : player1;
        }
        
        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            player1.Point++;
        }

        private void P2Score()
        {
            player2.Point++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }
    }
}