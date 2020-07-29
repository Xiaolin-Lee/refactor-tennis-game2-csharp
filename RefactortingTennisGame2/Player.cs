namespace RefactortingTennisGame2
{
    public class Player
    {
        public readonly string Name;
        public int Point;

        public string Result => Point >= 4 ? Score[3] : Score[Point];

        private static readonly string[] Score = {"Love", "Fifteen", "Thirty", "Forty"};
        public Player(string name)
        {
            Name = name;
            Point = 0;
        }

        public override int GetHashCode()
        {
            return Point.GetHashCode();
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

        public bool MathPoint()
        {
            return Point >= 3;
        }

        public bool WinPoint()
        {
            return Point >= 4;
        }
    }
}