namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    internal sealed class Board
    {
        private readonly Dictionary<(Int32 row, Int32 column), Boolean> _positions = new() {
                { (0, 0), default }, { (0, 1), default }, { (0, 2), default },
                { (1, 0), default }, { (1, 1), default }, { (1, 2), default },
                { (2, 0), default }, { (2, 1), default }, { (2, 2), default },
        };

        internal void MarkPosition (
                Int32 row,
                Int32 column )
        {
            Contract<OffBoardPosition>
                    .Requires( this._positions.ContainsKey( (row, column) ) );
            Contract<AlreadyMarkedPosition>
                    .Requires( this._positions[(row, column)] == false );
            this._positions[(row, column)] = true;
        }

        internal Boolean IsEmpty ()
        {
            return this._positions
                    .All( static position =>
                            position.Value == default );
        }
    }
}
