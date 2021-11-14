namespace Exeal.Katas.TicTacToe
{
	public sealed class Player
	{
		private Player () { }

		public static Player X { get; } = new()  { Mark = Mark.X };
		public static Player O { get; } = new()  { Mark = Mark.O };

		internal Mark Mark { get; private init; }
	}
}
