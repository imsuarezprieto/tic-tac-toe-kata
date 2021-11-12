namespace Exeal.Katas.TicTacToe.Tests
{
    using System.Collections;
    using Xunit;


    public sealed class UnitTest1
    {
        [Fact]
        public void Game_starts_with_an_empty_board ()
        {
            IEnumerable newGameBoard = new Game().Board;

            Assert.Empty( newGameBoard );
        }
    }
}
