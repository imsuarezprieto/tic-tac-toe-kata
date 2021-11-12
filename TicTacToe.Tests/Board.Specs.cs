// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
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

            startBoard
                    .Should().OnlyContain( static position =>
                            position.Value == false );
        }
    }
}
