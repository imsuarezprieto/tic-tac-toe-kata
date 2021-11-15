namespace Exeal.Katas.TicTacToe
{
	public sealed class Game
	{
		private readonly Board  _board         = new();
		private          Player _currentPlayer = Player.X;

		public Player? Winner ()
			=> this._board switch {
					var board when board.IsInLine( Player.X.Mark ) => Player.X,
					var board when board.IsInLine( Player.O.Mark ) => Player.O,
					_                                              => null,
			};

		public Game Play (
				IPosition position )
		{
			Contract.No<EndedGame>()
					.Requires( this._board.IsFull() is false )
					.Requires( this.Winner() is null )
					;
			this._board.MarkPosition( this._currentPlayer.Mark, position );
			this._currentPlayer++;
			return this;
		}
	}
}
