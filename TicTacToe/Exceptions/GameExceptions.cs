﻿namespace Exeal.Katas.TicTacToe
{
	using System;
	public sealed class InvalidTurn : Exception { }
	public sealed class AlreadyMarkedPosition : Exception { }
	public sealed class EndedGame : Exception { }
}
