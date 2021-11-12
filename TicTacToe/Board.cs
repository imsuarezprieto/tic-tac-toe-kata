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
                (Row, Column) position )
        {
            Contract<OffBoardPosition>
                    .Requires( this._positions.ContainsKey( position ) );
            Contract<AlreadyMarkedPosition>
                    .Requires( this._positions[position] == false );
            this._positions[position] = true;
        }

        internal Boolean IsEmpty ()
        {
            return this._positions
                    .All( static position =>
                            position.Value == default );
        }
    }
}
