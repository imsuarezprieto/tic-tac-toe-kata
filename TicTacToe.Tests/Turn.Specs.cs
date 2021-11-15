// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
	using FluentAssertions;
	using Xunit;


	[Collection( "Rule 2" )]
	public sealed class Players_marks_in_turns
	{
		[Fact]
		public void PlayerX_cannot_mark_two_consecutive_turns () { }

		[Fact]
		public void PlayerO_cannot_mark_two_consecutive_turns () { }

		[Fact]
		public void Players_can_mark_in_turns ()
		{
			var newGame = new Game();

			newGame
					.Play( Position.Middle.Middle )
					.Play( Position.Bottom.Right )
					.Play( Position.Top.Left );

			newGame.Winner()
					.Should().BeNull(  );
		}
	}
}
