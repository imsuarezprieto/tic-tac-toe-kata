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
            if (this._lastTurn == Turn.PlayerX) throw new InvalidTurn();
            this._lastTurn = Turn.PlayerX;
        }

        public void PlayO ()
        {
            if (this._lastTurn == Turn.PlayerO) throw new InvalidTurn();
            this._lastTurn = Turn.PlayerO;
        }


        private enum Turn
        {
            PlayerO,
            PlayerX,
        }
    }
}
