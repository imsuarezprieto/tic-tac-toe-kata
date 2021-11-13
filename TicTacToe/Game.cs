namespace Exeal.Katas.TicTacToe
{
    using System;


    public sealed class Game
    {
        public enum Player
        {
            PlayerO,
            PlayerX,
        }


        private readonly Board _board = new();
        private Turn _lastTurn;

        public Player? Winner () =>
                this._board switch {
                        var board when board.IsInLine( Mark.X ) => Player.PlayerX,
                        var board when board.IsInLine( Mark.O ) => Player.PlayerO,
                        _                                       => null,
                };

        public Game Play (
                IPosition position ) =>
                this._lastTurn == Turn.PlayerX
                        ? this.PlayO( position )
                        : this.PlayX( position );

        public Game PlayX (
                IPosition position )
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerX );

            this._lastTurn = Turn.PlayerX;
            this._board.MarkPosition( Mark.X, position );
            return this;
        }

        public Game PlayO (
                IPosition position )
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerO );

            this._lastTurn = Turn.PlayerO;
            this._board.MarkPosition( Mark.O, position );
            return this;
        }

        public Boolean HasEmptyBoard () =>
                this._board.IsEmpty();


        private enum Turn
        {
            PlayerO,
            PlayerX,
        }
    }
}
