namespace Exeal.Katas.TicTacToe
{
	public sealed class Game
	{
		private readonly Board  _board      = new();
		private          Player _nextPlayer = Player.X;

		public Player? Winner ()
			=> this._board switch {
					var board when board.IsInLine( Player.X.Mark ) => Player.X,
					var board when board.IsInLine( Player.O.Mark ) => Player.O,
					_                                              => null,
			};

		public Game Play (
				IPosition position )
			=> this._nextPlayer == Player.X
					? this.PlayX( position )
					: this.PlayO( position );

		public Game PlayX (
				IPosition position )
		{
			Contract<InvalidTurn>
					.Requires( this._nextPlayer == Player.X );

			this._nextPlayer = Player.O;
			this._board.MarkPosition( Mark.X, position );
			return this;
		}

		public Game PlayO (
				IPosition position )
		{
			Contract<InvalidTurn>
					.Requires( this._nextPlayer == Player.O );

			this._nextPlayer = Player.X;
			this._board.MarkPosition( Mark.O, position );
			return this;
		}
	}
}
