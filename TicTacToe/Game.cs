namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;


    public sealed class Game
    {
        public IEnumerable<Char> Board { get; set; } = new List<Char>();

        public void PlayX () { }

        public void PlayO ()
        {
            throw new InvalidTurn();
        }
    }
}
