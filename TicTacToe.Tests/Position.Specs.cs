// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable InconsistentNaming

namespace Exeal.Katas.TicTacToe.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;


    [Collection( "Rule 3" )]
    public sealed class Players_cannot_mark_already_marked_position
    {
        [Fact]
        public void PlayerO_cannot_mark_previous_playerX_marked_position ()
        {
            var newGame = new Game();

            Action playerO_marks_same_playerX = () => {
                newGame.PlayX( row: 1, column: 1 );
                newGame.PlayO( row: 1, column: 1 );
            };

            playerO_marks_same_playerX
                    .Should().Throw<AlreadyMarkedPosition>();
        }

        [Fact]
        public void PlayerO_can_mark_different_position_from_previous_playerX_marked_position ()
        {
            var newGame = new Game();

            Action playerO_marks_same_playerX = () => {
                newGame.PlayX( row: 1, column: 1 );
                newGame.PlayO( row: 1, column: 2 );
            };

            playerO_marks_same_playerX
                    .Should().NotThrow();
        }

        [Fact]
        public void PlayerX_cannot_mark_same_position_twice ()
        {
            var newGame = new Game();

            Action playerX_marks_same_position_twice = () => {
                newGame.PlayX( row: 1, column: 1 );
                newGame.PlayO( row: 1, column: 2 );
                newGame.PlayX( row: 1, column: 1 );
            };

            playerX_marks_same_position_twice
                    .Should().Throw<AlreadyMarkedPosition>();
        }

        [Fact]
        public void PlayerO_cannot_mark_same_position_twice ()
        {
            var newGame = new Game();

            Action playerO_marks_same_position_twice = () => {
                newGame.PlayX( row: 1, column: 1 );
                newGame.PlayO( row: 1, column: 2 );
                newGame.PlayX( row: 2, column: 1 );
                newGame.PlayO( row: 1, column: 2 );
            };

            playerO_marks_same_position_twice
                    .Should().Throw<AlreadyMarkedPosition>();
        }
    }
}