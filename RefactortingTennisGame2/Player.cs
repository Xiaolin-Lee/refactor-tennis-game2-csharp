namespace RefactortingTennisGame2
{
    class Player
    {
        private string Name;
        public int Point;
        public string Result;

        public Player(string Name)
        {
            this.Name = Name;
            this.Point = 0;
        }
    }
}