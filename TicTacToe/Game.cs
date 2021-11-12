namespace Exeal.Katas.TicTacToe
{
    using System.Collections;


    public sealed class Game
    {
        public IEnumerable Board { get; set; } = new ArrayList();
    }
}
