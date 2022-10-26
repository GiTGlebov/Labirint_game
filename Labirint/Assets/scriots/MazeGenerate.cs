using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGeneratorCell
{
    public int X;
    public int Y;
    public bool wallleft=true;
    public bool wallbot=true;
    public bool visited=false; 
}
public class MazeGenerator
{
    public int height=9;
    public int width=16;

    public MazeGeneratorCell[,] GeneratorMaze()
    {
        MazeGeneratorCell[,] maze = new MazeGeneratorCell[width, height];
        for (int x =0; x<maze.GetLength(0);x++)
        {
            for (int y=0; y<maze.GetLength(1);y++)
            {
                maze[x, y] = new MazeGeneratorCell { X = x, Y = y };
            }
        }
        for (int x = 0; x < maze.GetLength(0); x++)
        {
            maze[x,height-1].wallleft = false;
        }
        for (int y = 0; y < maze.GetLength(1); y++)
        {
            maze[width - 1, y].wallbot = false;
        }
        RemoveWallback(maze);
        return maze;
    }
    private void RemoveWallback(MazeGeneratorCell[,] maze)
    {
        MazeGeneratorCell current = maze[0, 0];
        Stack<MazeGeneratorCell> stack = new Stack<MazeGeneratorCell>();
        current.visited = true;
        do
        {
            List<MazeGeneratorCell> unvisitedNeighbours= new List<MazeGeneratorCell>();
            int x = current.X;
            int y = current.Y;
            if (x > 0 && !maze[x - 1, y].visited) unvisitedNeighbours.Add(maze[x - 1, y]);
            if (y > 0 && !maze[x , y-1].visited) unvisitedNeighbours.Add(maze[x , y-1]);
            if (x < width - 2 && !maze[x + 1, y].visited) unvisitedNeighbours.Add(maze[x + 1, y]);
            if (y < height - 2 && !maze[x, y+1].visited) unvisitedNeighbours.Add(maze[x, y + 1]);
            if (unvisitedNeighbours.Count>0)
            {
                MazeGeneratorCell chosen = unvisitedNeighbours[UnityEngine.Random.Range(0, unvisitedNeighbours.Count)];
                RemoveWall(current, chosen);
                chosen.visited = true;
                current = chosen;
                stack.Push(chosen);
            }
            else
            {
                current = stack.Pop();


            }
        } while (stack.Count > 0);
    }

    private void RemoveWall(MazeGeneratorCell a, MazeGeneratorCell b)
    {
        if (a.X==b.X)
        {
            if (a.Y > b.Y) a.wallbot = false;
            else b.wallbot = false;
        }
        else
        {
            if (a.X > b.X) a.wallleft= false;
            else b.wallleft = false;
        }
    }
}
