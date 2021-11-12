namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        private Turn _lastTurn;
        public Dictionary<(Int32 row, Int32 column), Boolean> Board { get; set; } = new() {
                { (0, 0), default }, { (0, 1), default }, { (0, 2), default },
                { (1, 0), default }, { (1, 1), default }, { (1, 2), default },
                { (2, 0), default }, { (2, 1), default }, { (2, 2), default },
        };

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
            Contract<InvalidMarkedPosition>
                    .Requires( this.Board[(row, column)] == false );
            this.Board[(row, column)] = true;
            this.PlayX();
        }

        public void PlayO (
                Int32 row,
                Int32 column )
        {
            Contract<InvalidMarkedPosition>
                    .Requires( this.Board[(row, column)] == false );
            this.Board[(row, column)] = true;
            this.PlayO();
        }


        private enum Turn
        {
            PlayerO,
            PlayerX,
        }
    }
}
