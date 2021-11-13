namespace Exeal.Katas.TicTacToe
{
    using System;


    public sealed class Game
    {
        private readonly Board _board = new();
        private Turn _lastTurn;

        public void PlayX (
                IPosition position )
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerX );

            this._lastTurn = Turn.PlayerX;
            this._board.MarkPosition( position );
        }

        public void PlayO (
                IPosition position )
        {
            Contract<InvalidTurn>
                    .Requires( this._lastTurn != Turn.PlayerO );

            this._lastTurn = Turn.PlayerO;
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
