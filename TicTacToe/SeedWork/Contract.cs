namespace Exeal.Katas.TicTacToe
{
    using System;


    internal static class Contract<TException> where TException : Exception, new()
    {
        public static void Requires (
                Boolean condition
        )
        {
            if (!condition) throw new TException();
        }
    }
}