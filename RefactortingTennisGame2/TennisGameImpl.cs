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
                if (player1.Point == 0)
                    score = "Love";
                if (player1.Point == 1)
                    score = "Fifteen";
                if (player1.Point == 2)
                    score = "Thirty";
                score += "-All";
            }

            if (player1.Point == player2.Point && player1.Point >= 3)
                score = "Deuce";

            if (player1.Point > 0 && player2.Point == 0)
            {
                if (player1.Point == 1)
                    player1.Result = "Fifteen";
                if (player1.Point == 2)
                    player1.Result = "Thirty";
                if (player1.Point == 3)
                    player1.Result = "Forty";

                player2.Result = "Love";
                score = player1.Result + "-" + player2.Result;
            }

            if (player2.Point > 0 && player1.Point == 0)
            {
                if (player2.Point == 1)
                    player2.Result = "Fifteen";
                if (player2.Point == 2)
                    player2.Result = "Thirty";
                if (player2.Point == 3)
                    player2.Result = "Forty";

                player1.Result = "Love";
                score = player1.Result + "-" + player2.Result;
            }

            if (player1.Point > player2.Point && player1.Point < 4)
            {
                if (player1.Point == 2)
                    player1.Result = "Thirty";
                if (player1.Point == 3)
                    player1.Result = "Forty";
                if (player2.Point == 1)
                    player2.Result = "Fifteen";
                if (player2.Point == 2)
                    player2.Result = "Thirty";
                score = player1.Result + "-" + player2.Result;
            }

            if (player2.Point > player1.Point && player2.Point < 4)
            {
                if (player2.Point == 2)
                    player2.Result = "Thirty";
                if (player2.Point == 3)
                    player2.Result = "Forty";
                if (player1.Point == 1)
                    player1.Result = "Fifteen";
                if (player1.Point == 2)
                    player1.Result = "Thirty";
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