// ReSharper disable InconsistentNaming
// ReSharper disable SuggestVarOrType_Elsewhere

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

            newGame.HasEmptyBoard()
                    .Should().BeTrue();
        }
    }


    [Collection( "Rule 0" )]
    public sealed class Avoid_off_board_positions
    {
        [Fact]
        public void PlayerX_cannot_mark_off_board ()
        {
            var newGame = new Game();

            Action player_marks_off_board = () =>
                    newGame.PlayX( row: 3, column: 3 );

            player_marks_off_board
                    .Should().Throw<OffBoardPosition>();
        }

        [Fact]
        public void PlayerO_cannot_mark_off_board ()
        {
            var newGame = new Game();

            Action player_marks_off_board = () =>
                    newGame.PlayO( row: -1, column: 1 );

            player_marks_off_board
                    .Should().Throw<OffBoardPosition>();
        }
    }
}
