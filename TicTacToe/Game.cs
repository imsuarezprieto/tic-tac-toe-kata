namespace Exeal.Katas.TicTacToe
{
    using Exeal.Katas.TicTacToe.Exceptions;
    using Exeal.Katas.TicTacToe.SeedWork;


    public sealed class Game
    {
        private readonly Board  board         = new();
        private          Player currentPlayer = Player.X;

        public Game Play (
                Position position )
        {
            Contract.No<EndedGame>()
                    .Requires( board.IsFull() is false )
                    .Requires( Winner() is null )
                    ;
            board.MarkPosition( currentPlayer.Mark, position );
            currentPlayer++;
            return this;
        }

        public Player? Winner ()
            => board switch {
                    _ when board.IsInLine( Player.X.Mark ) => Player.X,
                    _ when board.IsInLine( Player.O.Mark ) => Player.O,
                    _                                      => null,
            };
    }
}
