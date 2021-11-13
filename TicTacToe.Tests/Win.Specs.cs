// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 4" )]
    public sealed class Players_with_three_marks_in_line_wins
    {
        [Fact]
        public void PlayerX_first_to_mark_three_marks_in_line_wins ()
        {
            var game = new Game();

            // X O O
            // · X ·
            // · · X
            game.PlayX( Position.Center );
            game.PlayO( Position.Top.Right );
            game.PlayX( Position.Bottom.Right );
            game.PlayO( Position.Top.Middle );
            game.PlayX( Position.Top.Left );

            var winner = game.Winner();

            winner.Should().Be( Game.Player.PlayerX );
        }
    }
}
