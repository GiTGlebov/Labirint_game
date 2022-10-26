using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazespawner : MonoBehaviour
{
    public GameObject Cellprefab;
    void Start()
    {
        MazeGenerator generator = new MazeGenerator();
        MazeGeneratorCell[,] maze = generator.GeneratorMaze();
        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
               Cells c =Instantiate(Cellprefab, new Vector3(x, y), Quaternion.identity).GetComponent<Cells>();
                c.wallleft.SetActive(maze[x,y].wallleft);
                c.wallbot.SetActive(maze[x,y].wallbot);
            }
        }
    }

}
