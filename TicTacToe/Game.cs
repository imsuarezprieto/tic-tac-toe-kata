namespace Exeal.Katas.TicTacToe
{
	public sealed class Game
	{
		private readonly Board _board = new();
		private          Turn  _lastTurn;

		public Player? Winner ()
			=> this._board switch {
					var board when board.IsInLine( Player.X.Mark ) => Player.X,
					var board when board.IsInLine( Player.O.Mark ) => Player.O,
					_                                              => null,
			};

		public Game Play (
				IPosition position )
			=> this._lastTurn == Turn.PlayerX
					? this.PlayO( position )
					: this.PlayX( position );

		public Game PlayX (
				IPosition position )
		{
			Contract<InvalidTurn>
					.Requires( this._lastTurn != Turn.PlayerX );

			this._lastTurn = Turn.PlayerX;
			this._board.MarkPosition( Mark.X, position );
			return this;
		}

		public Game PlayO (
				IPosition position )
		{
			Contract<InvalidTurn>
					.Requires( this._lastTurn != Turn.PlayerO );

			this._lastTurn = Turn.PlayerO;
			this._board.MarkPosition( Mark.O, position );
			return this;
		}


		private enum Turn
		{
			PlayerO,
			PlayerX,
		}
	}
}
