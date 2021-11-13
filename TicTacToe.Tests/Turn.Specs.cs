// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 2" )]
    public sealed class Players_marks_in_turns
    {
        [Fact]
        public void PlayerX_cannot_mark_two_consecutive_turns ()
        {
            var newGame = new Game();

            Action playerX_marks_two_consecutive_turns = () => {
                newGame.PlayX( Position.Center );
                newGame.PlayX( Position.Center );
            };

            playerX_marks_two_consecutive_turns
                    .Should().Throw<InvalidTurn>();
        }

        [Fact]
        public void PlayerO_cannot_mark_two_consecutive_turns ()
        {
            var newGame = new Game();

            Action playerO_marks_two_consecutive_turns = () => {
                newGame.PlayX( Position.Center );
                newGame.PlayO( Position.Middle.Left );
                newGame.PlayO( Position.Middle.Left );
            };

            playerO_marks_two_consecutive_turns
                    .Should().Throw<InvalidTurn>();
        }

        [Fact]
        public void Players_can_mark_in_turns ()
        {
            var newGame = new Game();

            Action players_marks_in_turns = () => {
                newGame.PlayX( Position.Center );
                newGame.PlayO( Position.Bottom.Right );
                newGame.PlayX( Position.Top.Middle );
            };

            players_marks_in_turns
                    .Should().NotThrow();
        }
    }
}
