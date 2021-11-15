namespace Exeal.Katas.TicTacToe
{
	using System.Collections.Generic;


	public sealed partial class Position
	{
		public static Row Top    { get; } = new();
		public static Row Middle { get; } = new();
		public static Row Bottom { get; } = new();

		internal Position () { }
	}


	public sealed class Row
	{
		public Position Left   { get; } = new();
		public Position Middle { get; } = new();
		public Position Right  { get; } = new();

		internal Row () { }
	}


	public sealed partial class  Position
	{
		internal static IEnumerable<IEnumerable<Position>> Lines {
			get {
				yield return new List<Position> { Position.Top.Left,    Position.Top.Middle,    Position.Top.Right };
				yield return new List<Position> { Position.Middle.Left, Position.Middle.Middle, Position.Middle.Right };
				yield return new List<Position> { Position.Bottom.Left, Position.Bottom.Middle, Position.Bottom.Right };
				yield return new List<Position> { Position.Top.Left,    Position.Middle.Left,   Position.Bottom.Left };
				yield return new List<Position> { Position.Top.Middle,  Position.Middle.Middle, Position.Bottom.Middle };
				yield return new List<Position> { Position.Top.Right,   Position.Middle.Right,  Position.Bottom.Right };
				yield return new List<Position> { Position.Top.Left,    Position.Middle.Middle, Position.Bottom.Right };
				yield return new List<Position> { Position.Top.Right,   Position.Middle.Middle, Position.Bottom.Left };
			}
		}
	}
}