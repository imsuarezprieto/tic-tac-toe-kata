// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;


    public sealed class UnitTest1
    {
        // RULE 0

        [Fact]
        public void Game_starts_with_an_empty_board ()
        {
            var newGame = new Game();

            var startBoard = newGame.Board;

            startBoard.Should().BeEmpty();
        }

        // RULE 1

        [Fact]
        public void PlayerX_can_start_the_game ()
        {
            var newGame = new Game();

            Action playerXStarts = () => newGame.PlayX();

            playerXStarts.Should().NotThrow();
        }

        [Fact]
        public void PlayerO_cannot_start_the_game ()
        {
            var newGame = new Game();

            Action playerXStarts = () => newGame.PlayO();

            playerXStarts.Should().Throw<InvalidTurn>();
        }
    }
}
