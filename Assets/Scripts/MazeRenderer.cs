using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRenderer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(1,50)]
     private int width =10;
    [SerializeField]
    [Range(1,50)]
     private int height= 10;
    [SerializeField]
    private float size = 1f;

    [SerializeField] private Transform WallPrefab = null;
    void Start()
    {
        var maze = Mazegenerator.Generate(width, height);
        Draw(maze);

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void Draw(WallState[,] maze) {
    for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var cell = maze[i,j];
                var position = new Vector3(-width/2 + i, 0, -height/2+j);

                if (cell.HasFlag(WallState.up))
                {
                    var topWall = Instantiate(WallPrefab, transform) as Transform;
                    topWall.position = position + new Vector3(0,0,size);
                    topWall.localScale = new Vector3(size, topWall.localScale.y, topWall.localScale.z);

                }
                if (cell.HasFlag(WallState.left))
                {
                    var leftwall = Instantiate(WallPrefab, transform) as Transform;
                    leftwall.position = position + new Vector3(-size / 2, 0, leftwall.localScale.z);
                    leftwall.eulerAngles=new Vector3(0,90,0);
                }
                if (i == width - 1)
                {
                    if (cell.HasFlag(WallState.right))
                    {
                        var rightwall = Instantiate(WallPrefab, transform) as Transform;
                        rightwall.position = position + new Vector3(+size/2, rightwall.localScale.y - 1, rightwall.localScale.z);
                        rightwall.eulerAngles = new Vector3(0, 90, 0);
                    }
                }
                if (j == 0)
                {
                    if(cell.HasFlag(WallState.down))
                    {
                        var bottomwall = Instantiate(WallPrefab, transform) as Transform;
                        bottomwall.position = position + new Vector3(0,0,-size/2);
                        bottomwall.localScale = new Vector3(size, bottomwall.localScale.y, bottomwall.localScale.z);
                    }
                }
            }
        }
    }

}
