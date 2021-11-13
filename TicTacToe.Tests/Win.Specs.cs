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

        [Fact]
        public void PlayerO_first_to_mark_three_marks_in_line_wins ()
        {
            var game = new Game();

            // O O O
            // · X ·
            // X · X
            game.PlayX( Position.Center );
            game.PlayO( Position.Top.Right );
            game.PlayX( Position.Bottom.Right );
            game.PlayO( Position.Top.Middle );
            game.PlayX( Position.Bottom.Left );
            game.PlayO( Position.Top.Left );

            var winner = game.Winner();

            winner.Should().Be( Game.Player.PlayerO );
        }

        [Fact]
        public void No_player_wins_if_no_three_marks_in_line_wins ()
        {
            var game = new Game();

            // O X O
            // X X O
            // X O X
            game.PlayX( Position.Center );
            game.PlayO( Position.Top.Right );
            game.PlayX( Position.Bottom.Right );
            game.PlayO( Position.Top.Left );
            game.PlayX( Position.Bottom.Left );
            game.PlayO( Position.Bottom.Middle );
            game.PlayX( Position.Middle.Left );
            game.PlayO( Position.Middle.Right );
            game.PlayX( Position.Top.Middle );

            var winner = game.Winner();

            winner.Should().BeNull();
        }
    }
}
