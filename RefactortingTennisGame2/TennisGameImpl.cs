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
            string score = "";
            if (player1.Point == player2.Point && player1.Point < 4)
            {
                score = player1.Result;
                score += "-All";
            }

            if (player1.Point == player2.Point && player1.Point >= 3)
                score = "Deuce";

            if (player1.Point > 0 && player2.Point == 0)
            {
                score = player1.Result + "-" + player2.Result;
            }

            if (player2.Point > 0 && player1.Point == 0)
            {
                score = player1.Result + "-" + player2.Result;
            }

            if (player1.Point > player2.Point && player1.Point < 4)
            {
                score = player1.Result + "-" + player2.Result;
            }

            if (player2.Point > player1.Point && player2.Point < 4)
            {
                score = player1.Result + "-" + player2.Result;
            }

            if (player1.Point > player2.Point && player2.Point >= 3)
            {
                score = "Advantage player1";
            }

            if (player2.Point > player1.Point && player1.Point >= 3)
            {
                score = "Advantage player2";
            }

            if (player1.Point >= 4 && player2.Point >= 0 && (player1.Point - player2.Point) >= 2)
            {
                score = "Win for player1";
            }

            if (player2.Point >= 4 && player1.Point >= 0 && (player2.Point - player1.Point) >= 2)
            {
                score = "Win for player2";
            }

            return score;
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

        public void P1Score()
        {
            player1.Point++;
        }

        public void P2Score()
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