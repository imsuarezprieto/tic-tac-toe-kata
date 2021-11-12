// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable InconsistentNaming

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 0" )]
    public sealed class Starts_empty_Board
    {
        [Fact]
        public void Game_starts_with_an_empty_board ()
        {
            var newGame = new Game();

            var startBoard = newGame.Board;

            startBoard.Should().BeEmpty();
        }
    }


    [Collection( "Rule 1" )]
    public sealed class PlayerX_starts_game
    {
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
