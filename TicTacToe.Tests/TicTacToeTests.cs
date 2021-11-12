// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using FluentAssertions;
    using Xunit;


    public sealed class UnitTest1
    {
        [Fact]
        public void Game_starts_with_an_empty_board ()
        {
            var newGame = new Game();

            var startBoard = newGame.Board;

            startBoard.Should().BeEmpty();
        }
    }
}
