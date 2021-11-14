// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
	using FluentAssertions;
	using Xunit;


	[Collection( "Rule 1" )]
	public sealed class PlayerX_starts_game
	{
		[Fact]
		public void PlayerX_starts_the_game ()
		{
			var newGame = new Game();

			newGame
					.Play( Position.Center )
					.Play( Position.Top.Middle )
					.Play( Position.Top.Right )
					.Play( Position.Bottom.Middle )
					.Play( Position.Bottom.Left );

			newGame.Winner()
					.Should().Be( Player.X );
		}

		[Fact]
		public void PlayerX_can_start_the_game () { }

		[Fact]
		public void PlayerO_cannot_start_the_game () { }
	}
}
