// ReSharper disable InconsistentNaming

namespace Exeal.Katas.TicTacToe
{
    public sealed partial class Player
    {
        private  Player Next = null!;
        internal Mark   Mark { get; private init; }

        public static Player operator ++ (
                Player player )
            => player.Next;
    }


    public sealed partial class Player
    {
        public static readonly Player X = new()  { Mark = Mark.X };
        public static readonly Player O = new()  { Mark = Mark.O };

        static Player ()
        {
            Player.X.Next = Player.O;
            Player.O.Next = Player.X;
        }

        private Player () { }
    }
}
