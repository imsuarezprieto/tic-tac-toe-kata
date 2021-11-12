namespace Exeal.Katas.TicTacToe.Tests
{
    using FluentAssertions;
    using Xunit;


    public sealed class UnitTest1
    {
        [Fact]
        public void Game_starts_with_an_empty_board () =>
                new Game().Board
                        .Should().BeEmpty();
    }
}
