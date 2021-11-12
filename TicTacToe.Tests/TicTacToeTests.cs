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

            startBoard
                    .Should().BeEmpty();
        }
    }


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
                    .Should().Throw<InvalidMarkedPosition>();
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
                    .Should().Throw<InvalidMarkedPosition>();
        }
    }
}
