namespace Exeal.Katas.TicTacToe
{
	public sealed class Player
	{
		public static Player X { get; } = new()  { Mark = Mark.X };
		public static Player O { get; } = new()  { Mark = Mark.O };

		static Player ()
		{
			Player.X.NextPlayer = Player.O;
			Player.O.NextPlayer = Player.X;
		}

		internal Mark   Mark       { get; private init; }
		private  Player NextPlayer { get; set; }

		private Player () { }

		public static Player operator ++ (
				Player player )
			=> player.NextPlayer;
	}
}
