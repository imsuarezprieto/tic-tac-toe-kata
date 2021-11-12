namespace Exeal.Katas.TicTacToe
{
    using System;


    public sealed class Game
    {
        private readonly Board _board = new();
        private Turn _lastTurn;

        public void PlayX ()
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerX );
            this._lastTurn = Turn.PlayerX;
        }

        public void PlayO ()
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerO );
            this._lastTurn = Turn.PlayerO;
        }

        public void PlayX (
                Int32 row,
                Int32 column )
        {
            this._board.MarkPosition( row, column );
            this.PlayX();
        }

        public void PlayO (
                Int32 row,
                Int32 column )
        {
            this._board.MarkPosition( row, column );
            this.PlayO();
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
