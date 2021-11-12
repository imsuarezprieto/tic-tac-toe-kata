namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        private Char _lastTurn = 'O';
        public IEnumerable<Char> Board { get; set; } = new List<Char>();

        public void PlayX ()
        {
            if (this._lastTurn == 'X') throw new InvalidTurn();
            this._lastTurn = 'X';
        }

        public void PlayO ()
        {
            if (this._lastTurn == 'O') throw new InvalidTurn();
            this._lastTurn = 'O';
        }
    }
}
