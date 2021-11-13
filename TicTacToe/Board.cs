namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    internal sealed class Board
    {
        private readonly Dictionary<Position, Boolean> _positions = new() {
                { new Position( Row: Row.Top,    Column: Column.Left ),     default },
                { new Position( Row: Row.Top,    Column: Column.Middle ),   default },
                { new Position( Row: Row.Top,    Column: Column.Right ),    default },
                { new Position( Row: Row.Middle, Column: Column.Left ),     default },
                { new Position( Row: Row.Middle, Column: Column.Middle ),   default },
                { new Position( Row: Row.Middle, Column: Column.Right ),    default },
                { new Position( Row: Row.Bottom, Column: Column.Left ),     default },
                { new Position( Row: Row.Bottom, Column: Column.Middle ),   default },
                { new Position( Row: Row.Bottom, Column: Column.Right ),    default },
        };

        internal void MarkPosition (
                Int32 row,
                Int32 column )
        {
            Contract<OffBoardPosition>
                    .Requires( this._positions.ContainsKey( new Position( Row: (Row) row, Column: (Column) column ) ) );
            Contract<AlreadyMarkedPosition>
                    .Requires( this._positions[new Position( Row: (Row) row, Column: (Column) column )] == false );
            this._positions[new Position( Row: (Row) row, Column: (Column) column )] = true;
        }

        internal Boolean IsEmpty ()
        {
            return this._positions
                    .All( static position =>
                            position.Value == default );
        }
    }
}
