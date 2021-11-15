// ReSharper disable InconsistentNaming
// ReSharper disable StaticMemberInitializerReferesToMemberBelow

namespace Exeal.Katas.TicTacToe
{
    using System.Collections.Generic;


    public sealed partial class Position
    {
        public static readonly Row Top    = new();
        public static readonly Row Middle = new();
        public static readonly Row Bottom = new();

        internal Position () { }
    }


    public sealed class Row
    {
        public readonly Position Left   = new();
        public readonly Position Middle = new();
        public readonly Position Right  = new();

        internal Row () { }
    }


    public sealed partial class  Position
    {
        internal static readonly List<List<Position>> Lines =
                new() {
                        new() { Position.Top.Left,    Position.Top.Middle,    Position.Top.Right },
                        new() { Position.Middle.Left, Position.Middle.Middle, Position.Middle.Right },
                        new() { Position.Bottom.Left, Position.Bottom.Middle, Position.Bottom.Right },
                        new() { Position.Top.Left,    Position.Middle.Left,   Position.Bottom.Left },
                        new() { Position.Top.Middle,  Position.Middle.Middle, Position.Bottom.Middle },
                        new() { Position.Top.Right,   Position.Middle.Right,  Position.Bottom.Right },
                        new() { Position.Top.Left,    Position.Middle.Middle, Position.Bottom.Right },
                        new() { Position.Top.Right,   Position.Middle.Middle, Position.Bottom.Left },
                };
    }
}
