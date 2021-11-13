namespace Exeal.Katas.TicTacToe
{
    using System.Collections.Generic;
    public interface IPosition { }


    public interface IRow
    {
        public IPosition Left   { get; }
        public IPosition Middle { get; }
        public IPosition Right  { get; }
    }


    public static class Position
    {
        public static IRow      Top    { get; } = new Row( Rows.Top );
        public static IRow      Middle { get; } = new Row( Rows.Middle );
        public static IRow      Bottom { get; } = new Row( Rows.Bottom );
        public static IPosition Center { get; } = new Coordinates( Rows.Middle, Columns.Middle );

        internal static IEnumerable<IEnumerable<IPosition>> Lines {
            get {
                yield return new List<IPosition> { Position.Top.Left,    Position.Top.Middle,    Position.Top.Right };
                yield return new List<IPosition> { Position.Middle.Left, Position.Middle.Middle, Position.Middle.Right };
                yield return new List<IPosition> { Position.Bottom.Left, Position.Bottom.Middle, Position.Bottom.Right };
                yield return new List<IPosition> { Position.Top.Left,    Position.Middle.Left,   Position.Bottom.Left };
                yield return new List<IPosition> { Position.Top.Middle,  Position.Middle.Middle, Position.Bottom.Middle };
                yield return new List<IPosition> { Position.Top.Right,   Position.Middle.Right,  Position.Bottom.Right };
                yield return new List<IPosition> { Position.Top.Left,    Position.Middle.Middle, Position.Bottom.Right };
                yield return new List<IPosition> { Position.Top.Right,   Position.Middle.Middle, Position.Bottom.Left };
            }
        }


        private enum Columns
        {
            Left,
            Middle,
            Right,
        }


        private enum Rows
        {
            Top,
            Middle,
            Bottom,
        }


        private readonly record struct Row(
                        Rows row )
                : IRow

        {
            public IPosition Left   { get; } = new Coordinates( row, Columns.Left );
            public IPosition Middle { get; } = new Coordinates( row, Columns.Middle );
            public IPosition Right  { get; } = new Coordinates( row, Columns.Right );
        }


        private readonly record struct Coordinates(
                        Rows    Rows,
                        Columns Columns )
                : IPosition { }
    }
}
