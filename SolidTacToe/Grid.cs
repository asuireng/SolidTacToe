﻿using SolidTacToe.Definitions;

namespace SolidTacToe
{
    /// <summary>
    /// Keeps track of the current state of the game. This class
    /// should only change if the underlying data structure changes.
    /// </summary>
    public class Grid : IGrid, IGridMatrix
    {
        public Token[,] Slots { get;  set; }
        public int Size { get; set; }

        public Token Get(int x, int y)
        {
            return Slots[x, y];
        }

        public void Set(Token t, int x, int y)
        {
            Slots[x, y] = t;
        }
    }
}
