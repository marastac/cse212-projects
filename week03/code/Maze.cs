using System;
using System.Collections.Generic;

public class Maze
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Maze(int startX = 0, int startY = 0)
    {
        X = startX;
        Y = startY;
    }

    public void MoveLeft()
    {
        X -= 1;
    }

    public void MoveRight()
    {
        X += 1;
    }

    public void MoveUp()
    {
        Y += 1;
    }

    public void MoveDown()
    {
        Y -= 1;
    }
}
