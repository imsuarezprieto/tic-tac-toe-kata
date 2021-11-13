namespace Exeal.Katas.TicTacToe
{
    public readonly record struct Position(
            Row    Row,
            Column Column );


    public enum Row
    {
        Top,
        Middle,
        Bottom,
    }


    public enum Column
    {
        Left,
        Middle,
        Right,
    }
}
