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
                newGame.PlayX();
                newGame.PlayX();
            };

            playerX_marks_two_consecutive_turns
                    .Should().Throw<InvalidTurn>();
        }

        [Fact]
        public void PlayerO_cannot_mark_two_consecutive_turns ()
        {
            var newGame = new Game();

            Action playerX_marks_two_consecutive_turns = () => {
                newGame.PlayX();
                newGame.PlayO();
                newGame.PlayO();
            };

            playerX_marks_two_consecutive_turns
                    .Should().Throw<InvalidTurn>();
        }

        [Fact]
        public void Players_can_mark_in_turns ()
        {
            var newGame = new Game();

            Action players_marks_in_turns = () => {
                newGame.PlayX();
                newGame.PlayO();
                newGame.PlayX();
            };

            players_marks_in_turns
                    .Should().NotThrow();
        }
    }
}