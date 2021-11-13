namespace Exeal.Katas.TicTacToe
{
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
