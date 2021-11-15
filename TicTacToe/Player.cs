// ReSharper disable InconsistentNaming

namespace Exeal.Katas.TicTacToe
{
    public sealed partial class Player
    {
        private  Player NextPlayer = null!;
        internal Mark   Mark { get; private init; }

        public static Player operator ++ (
                Player player )
            => player.NextPlayer;
    }


    public sealed partial class Player
    {
        public static readonly Player X = new()  { Mark = Mark.X };
        public static readonly Player O = new()  { Mark = Mark.O };

        static Player ()
        {
            Player.X.NextPlayer = Player.O;
            Player.O.NextPlayer = Player.X;
        }

        private Player () { }
    }
}
