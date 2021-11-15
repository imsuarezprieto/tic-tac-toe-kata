﻿namespace Exeal.Katas.TicTacToe
{
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
                    var board when board.IsInLine( Player.X.Mark ) => Player.X,
                    var board when board.IsInLine( Player.O.Mark ) => Player.O,
                    _                                              => null,
            };
    }
}
