namespace Exeal.Katas.TicTacToe
{
	using System;
	using System.Collections.Generic;
	using System.Linq;


	internal sealed class Board
	{
		private readonly Dictionary<IPosition, Mark> _positions = new() {
				{ Position.Top.Left,      Mark.None },
				{ Position.Top.Middle,    Mark.None },
				{ Position.Top.Right,     Mark.None },
				{ Position.Middle.Left,   Mark.None },
				{ Position.Center,        Mark.None },
				{ Position.Middle.Right,  Mark.None },
				{ Position.Bottom.Left,   Mark.None },
				{ Position.Bottom.Middle, Mark.None },
				{ Position.Bottom.Right,  Mark.None },
		};

		internal Boolean IsInLine (
				Mark mark )
			=> Position.Lines
					.Any( line =>
							line.All( position =>
									this._positions[position] == mark ) );

		internal void MarkPosition (
				Mark      mark,
				IPosition position )
		{
			Contract<AlreadyMarkedPosition>
					.Requires( this._positions[position] == Mark.None );

			this._positions[position] = mark;
		}

		internal Boolean IsFull ()
			=> this._positions
					.All( static position =>
							position.Value != Mark.None );
	}
}
