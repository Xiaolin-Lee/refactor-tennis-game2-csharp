namespace RefactortingTennisGame2
{
    class Player
    {
        private string Name;
        public int Point;

        public string Result => Point >= 4 ? Score[3] : Score[Point];

        private static readonly string[] Score = {"Love", "Fifteen", "Thirty", "Forty"};
        public Player(string Name)
        {
            this.Name = Name;
            Point = 0;
        }
    }
}