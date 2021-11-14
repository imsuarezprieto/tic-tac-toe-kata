namespace Exeal.Katas.TicTacToe
{
	public sealed class Player
	{
		static Player ()
		{
			Player.X.NextPlayer = Player.O;
			Player.O.NextPlayer = Player.X;
		}

		private Player () { }

		public static Player X { get; } = new()  { Mark = Mark.X };
		public static Player O { get; } = new()  { Mark = Mark.O };

		internal Mark   Mark       { get; private init; }
		internal Player NextPlayer { get; private set; }
	}
}
