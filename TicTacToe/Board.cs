namespace Exeal.Katas.TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    internal sealed class Board
    {
        private readonly Dictionary<IPosition, Boolean> _positions = new() {
                { Position.Top.Left,      default },
                { Position.Top.Middle,    default },
                { Position.Top.Right,     default },
                { Position.Middle.Left,   default },
                { Position.Center,        default },
                { Position.Middle.Right,  default },
                { Position.Bottom.Left,   default },
                { Position.Bottom.Middle, default },
                { Position.Bottom.Right,  default },
        };

        internal void MarkPosition (
                IPosition position )
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
