namespace Exeal.Katas.TicTacToe.SeedWork
{
    using System;


    internal static class Contract
    {
        public static No<TException> No<TException> ()
                where TException : Exception, new()
            => new();
    }


    internal class No<TException> where TException : Exception, new()
    {
        public No<TException> Requires (
                Boolean condition )
        {
            if (!condition) throw new TException();

            return this;
        }
    }
}
