// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Xunit;


	[Collection( "Rule 0" )]
	public sealed class Starts_empty_Board
	{
		public static IEnumerable<Object[]> EveryPosition
			=> new List<Object[]> {
					new Object[] { Position.Top.Left },
					new Object[] { Position.Top.Middle },
					new Object[] { Position.Top.Right },
					new Object[] { Position.Middle.Left },
					new Object[] { Position.Middle.Middle },
					new Object[] { Position.Middle.Right },
					new Object[] { Position.Bottom.Left },
					new Object[] { Position.Bottom.Middle },
					new Object[] { Position.Bottom.Right },
			};

		[Theory]
		[MemberData( nameof(Starts_empty_Board.EveryPosition) )]
		public void Starting_players_can_mark_any_position (
				Position position )
		{
			var newGame = new Game();

			Action player_marks_position_on_board = () =>
					newGame.Play( position );

			player_marks_position_on_board
					.Should().NotThrow();
		}
	}


	[Collection( "Rule 0" )]
	public sealed class Avoid_off_board_positions
	{
		[Fact]
		public void PlayerX_cannot_mark_off_board () { }

		[Fact]
		public void PlayerO_cannot_mark_off_board () { }
	}
}
