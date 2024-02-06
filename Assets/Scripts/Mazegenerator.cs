using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WallState
{
    // 0000 -> No walls
    // 1111 -> LEFT, RIGHT, UP, DOWN
    left = 1, //0001
    right = 2, //0010
    up = 4, //0100
    down = 8, //1000
}
public static class Mazegenerator
{
    // Start is called before the first frame update
    public static WallState[,] Generate(int width, int height)
    {
        WallState[,] maze = new WallState[width, height];
        WallState initial = WallState.right | WallState.left | WallState.up | WallState.down;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = initial; //1111 
            }
        }
        return maze;
    }
}
