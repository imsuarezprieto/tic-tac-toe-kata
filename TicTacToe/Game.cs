namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        private Turn _lastTurn;
        private Int32? _previousMarkColumn;
        private Int32? _previousMarkedRow;
        public IEnumerable<Char> Board { get; set; } = new List<Char>();

        public void PlayX ()
        {
            Contract<InvalidTurn>.Requires( this._lastTurn != Turn.PlayerX );
            this._lastTurn = Turn.PlayerX;
        }

        public void PlayO ()
        {
            Contract<InvalidTurn>.Requires( this._lastTurn != Turn.PlayerO );
            this._lastTurn = Turn.PlayerO;
        }

        public void PlayX (
                Int32 row,
                Int32 column )
        {
            this._previousMarkedRow = row;
            this._previousMarkColumn = column;
            this.PlayX();
        }

        public void PlayO (
                Int32 row,
                Int32 column )
        {
            Contract<InvalidMarkedPosition>
                    .Requires( this._previousMarkedRow != row || this._previousMarkColumn != column );
            this.PlayO();
        }


        private enum Turn
        {
            PlayerO,
            PlayerX,
        }
    }
}
