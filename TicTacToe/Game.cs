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
                IPosition position )
        {
            this.PlayX();
            this._board.MarkPosition( position );
        }

        public void PlayO (
                IPosition position )
        {
            this.PlayO();
            this._board.MarkPosition( position );
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
