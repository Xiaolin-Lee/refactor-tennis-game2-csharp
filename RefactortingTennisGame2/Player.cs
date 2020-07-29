namespace RefactortingTennisGame2
{
    public class Player
    {
        public string Name;
        public int Point;

        public string Result => Point >= 4 ? Score[3] : Score[Point];

        private static readonly string[] Score = {"Love", "Fifteen", "Thirty", "Forty"};
        public Player(string Name)
        {
            this.Name = Name;
            Point = 0;
        }

        public override int GetHashCode()
        {
            return Point;
        }

        public override bool Equals(object? obj)
        {
            var another = obj as Player;
            if (another == null)
            {
                return false;
            }

            return another.Point == Point;
        }
    }
}