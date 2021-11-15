namespace Exeal.Katas.TicTacToe
{
	using System;
	using System.Collections.Generic;
	using System.Linq;


	internal sealed class Board
	{
		private readonly Dictionary<Position, Mark> positions = new() {
				{ Position.Top.Left,      Mark.None },
				{ Position.Top.Middle,    Mark.None },
				{ Position.Top.Right,     Mark.None },
				{ Position.Middle.Left,   Mark.None },
				{ Position.Middle.Middle, Mark.None },
				{ Position.Middle.Right,  Mark.None },
				{ Position.Bottom.Left,   Mark.None },
				{ Position.Bottom.Middle, Mark.None },
				{ Position.Bottom.Right,  Mark.None },
		};

		internal void MarkPosition (
				Mark     mark,
				Position position )
		{
			Contract.No<AlreadyMarkedPosition>()
					.Requires( positions[position] == Mark.None )
					;
			positions[position] = mark;
		}

		internal Boolean IsFull ()
			=> positions
					.All( static position =>
							position.Value != Mark.None );

		internal Boolean IsInLine (
				Mark mark )
			=> Position.Lines
					.Any( line =>
							line.All( position =>
									positions[position] == mark ) );
	}
}
