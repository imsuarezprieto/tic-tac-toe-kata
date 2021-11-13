// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 1" )]
    public sealed class PlayerX_starts_game
    {
        [Fact]
        public void PlayerX_can_start_the_game ()
        {
            var newGame = new Game();

            Action playerX_starts = () => newGame.PlayX();

            playerX_starts
                    .Should().NotThrow();
        }

        [Fact]
        public void PlayerO_cannot_start_the_game ()
        {
            var newGame = new Game();

            Action playerO_starts = () => newGame.PlayO();

            playerO_starts
                    .Should().Throw<InvalidTurn>();
        }
    }
}