namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        private Turn _lastTurn;
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


        private enum Turn
        {
            PlayerO,
            PlayerX,
        }
    }
}
