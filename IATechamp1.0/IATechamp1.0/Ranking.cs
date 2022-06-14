namespace IATechamp1._0
{
    public class Ranking : Scoreboard, IRanking
    {
        public Ranking( int playerPoints) : base(playerPoints)
        {
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
