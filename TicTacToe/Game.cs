namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        private Char lastTurn = 'O';
        public IEnumerable<Char> Board { get; set; } = new List<Char>();

        public void PlayX ()
        {
            if (this.lastTurn == 'X') throw new InvalidTurn();
            this.lastTurn = 'X';
        }

        public void PlayO ()
        {
            if (this.lastTurn == 'O') throw new InvalidTurn();
            this.lastTurn = 'O';
        }
    }
}
