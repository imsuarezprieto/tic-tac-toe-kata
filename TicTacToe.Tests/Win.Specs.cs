// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using Exeal.Katas.TicTacToe.Exceptions;
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 4" )]
    public sealed class Players_with_three_marks_in_line_wins
    {
        [Fact]
        public void PlayerX_first_to_mark_three_marks_in_line_wins ()
        {
            var game = new Game();

            game
                    .Play( Position.Middle.Middle )
                    .Play( Position.Top.Right )
                    .Play( Position.Bottom.Right )
                    .Play( Position.Top.Middle )
                    .Play( Position.Top.Left );

            game.Winner()
                    .Should().Be( Player.X );
        }

        [Fact]
        public void PlayerO_first_to_mark_three_marks_in_line_wins ()
        {
            var game = new Game();

            game
                    .Play( Position.Middle.Middle )
                    .Play( Position.Top.Right )
                    .Play( Position.Bottom.Right )
                    .Play( Position.Top.Middle )
                    .Play( Position.Bottom.Left )
                    .Play( Position.Top.Left );

            game.Winner()
                    .Should().Be( Player.O );
        }

        [Fact]
        public void No_player_wins_if_no_three_marks_in_line_wins ()
        {
            var game = new Game();

            game
                    .Play( Position.Middle.Middle )
                    .Play( Position.Top.Right )
                    .Play( Position.Bottom.Right )
                    .Play( Position.Top.Left )
                    .Play( Position.Bottom.Left )
                    .Play( Position.Bottom.Middle )
                    .Play( Position.Middle.Left )
                    .Play( Position.Middle.Right )
                    .Play( Position.Top.Middle );

            game.Winner()
                    .Should().BeNull();
        }

        [Fact]
        public void An_already_won_game_cannot_be_still_play ()
        {
            var game = new Game();

            Action winning_moves = () =>
                    game
                            .Play( Position.Middle.Middle )
                            .Play( Position.Top.Right )
                            .Play( Position.Bottom.Right )
                            .Play( Position.Top.Middle )
                            .Play( Position.Top.Left )
                            .Play( Position.Bottom.Right );

            winning_moves
                    .Should().Throw<EndedGame>();
        }
    }
}
