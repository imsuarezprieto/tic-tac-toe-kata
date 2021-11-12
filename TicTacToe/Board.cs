namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    internal sealed class Board
    {
        private readonly Dictionary<(Row, Column), Boolean> _positions = new() {
                { (Row.Top,    Column.Left),   default },
                { (Row.Top,    Column.Middle), default },
                { (Row.Top,    Column.Right),  default },
                { (Row.Middle, Column.Left),   default },
                { (Row.Middle, Column.Middle), default },
                { (Row.Middle, Column.Right),  default },
                { (Row.Bottom, Column.Left),   default },
                { (Row.Bottom, Column.Middle), default },
                { (Row.Bottom, Column.Right),  default },
        };

        internal void MarkPosition (
                Int32 row,
                Int32 column )
        {
            Contract<OffBoardPosition>
                    .Requires( this._positions.ContainsKey( ((Row) row, (Column) column) ) );
            Contract<AlreadyMarkedPosition>
                    .Requires( this._positions[((Row) row, (Column) column)] == false );
            this._positions[((Row) row, (Column) column)] = true;
        }

        internal Boolean IsEmpty ()
        {
            return this._positions
                    .All( static position =>
                            position.Value == default );
        }
    }
}
