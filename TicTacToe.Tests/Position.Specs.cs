// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable InconsistentNaming

namespace Exeal.Katas.TicTacToe.Tests
{
	using System;
	using FluentAssertions;
	using Xunit;


	[Collection( "Rule 3" )]
	public sealed class Players_cannot_mark_already_marked_position
	{
		[Fact]
		public void PlayerO_cannot_mark_previous_playerX_marked_position ()
		{
			var game = new Game();

			Action playerO_marks_same_playerX = ()
					=> game
							.Play( Position.Center )
							.Play( Position.Center );

			playerO_marks_same_playerX
					.Should().Throw<AlreadyMarkedPosition>();
		}

		[Fact]
		public void PlayerO_can_mark_different_position_from_previous_playerX_marked_position ()
		{
			var game = new Game();

			Action playerO_marks_same_playerX = () => game
					.Play( Position.Center )
					.Play( Position.Middle.Left );

			playerO_marks_same_playerX
					.Should().NotThrow();
		}

		[Fact]
		public void PlayerX_cannot_mark_same_position_twice ()
		{
			var game = new Game();

			Action playerX_marks_same_position_twice = () => game
					.Play( Position.Center )
					.Play( Position.Middle.Left )
					.Play( Position.Center );

			playerX_marks_same_position_twice
					.Should().Throw<AlreadyMarkedPosition>();
		}

		[Fact]
		public void PlayerO_cannot_mark_same_position_twice ()
		{
			var game = new Game();

			Action playerO_marks_same_position_twice = () => game
					.Play( Position.Center )
					.Play( Position.Middle.Right )
					.Play( Position.Bottom.Left )
					.Play( Position.Middle.Right );

			playerO_marks_same_position_twice
					.Should().Throw<AlreadyMarkedPosition>();
		}
	}
}
