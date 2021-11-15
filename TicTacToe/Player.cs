namespace Exeal.Katas.TicTacToe
{
    public sealed partial class Player
    {
        internal Mark   Mark       { get; private init; }
        private  Player NextPlayer { get; set; } = null!;

        public static Player operator ++ (
                Player player )
            => player.NextPlayer;
    }


    public sealed partial class Player
    {
        public static Player X { get; } = new()  { Mark = Mark.X };
        public static Player O { get; } = new()  { Mark = Mark.O };

        static Player ()
        {
            Player.X.NextPlayer = Player.O;
            Player.O.NextPlayer = Player.X;
        }

        private Player () { }
    }
}
