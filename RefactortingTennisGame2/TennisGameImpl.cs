using System;

namespace RefactortingTennisGame2
{
    public class TennisGameImpl : ITennisGame
    {
        private static int GAME_POINT = 3;
        private Player player1;
        private Player player2;

        public TennisGameImpl(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            string score = "";
            if (player1.Equals(player2))
            {
                if (!player1.MathPoint())
                {
                    score = player1.Result;
                    score += "-All";
                }

                if (player1.MathPoint())
                {
                    score = "Deuce";
                }
            }

            if (!player1.Equals(player2) && !Winner().WinPoint())
            {
                score = player1.Result + "-" + player2.Result;
            }

            if (!player1.Equals(player2) && CurrentLoser().MathPoint())
            {
                score = $"Advantage {Winner().Name}";
            }

            if (HasWinner())
            {
                score = $"Win for {Winner().Name}";
            }

            return score;
        }

        private bool HasWinner()
        {
            return (player1.WinPoint() || player2.WinPoint()) && Math.Abs(player1.Point - player2.Point) >= 2;
        }

        private Player Winner()
        {
            return player1.Point > player2.Point ? player1 : player2;
        }

        private Player CurrentLoser()
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