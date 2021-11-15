﻿// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
	using FluentAssertions;
	using Xunit;


	[Collection( "Rule 5" )]
	public sealed class Full_board__with_no_three_marks_in_line_is_draw
	{
		[Fact]
		public void No_player_wins_if_the_board_is_full_with_no_three_marks_in_line ()
		{
			var game = new Game();

			// X O X
			// X X O
			// O X O
			game
					.Play( Position.Top.Left )
					.Play( Position.Top.Middle )
					.Play( Position.Top.Right )
					.Play( Position.Middle.Right )
					.Play( Position.Middle.Left )
					.Play( Position.Bottom.Left )
					.Play( Position.Center )
					.Play( Position.Bottom.Right )
					.Play( Position.Bottom.Middle );

			game.Winner()
					.Should().BeNull();
		}
	}
}