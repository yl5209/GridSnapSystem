using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    public int gridSize;
    public float gapSize;

    public float activeRadius;
    public float snapRadius;
    public float snapSpeed;
    public float predictionLength;

    private Vector3[,] grid;
    private int size;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        size = gridSize * 2 + 1;
        grid = new Vector3[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                grid[i, j] = transform.position + new Vector3(-gapSize * gridSize + i * gapSize, 0, -gapSize * gridSize + j * gapSize);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if out-of-range
        if (Vector3.Distance(Move.player.position, transform.position) > activeRadius)
            return;

        UpdateGrid();

        SnapPlayer();
    }

    private void SnapPlayer()
    {
        if (Move.player.isMoving)
        {
            this.target = GetNode();
            return;
        }

        Vector3 target = (this.target - Move.player.transform.position) * snapSpeed;
        Move.player.DoMove(new Vector3(target.x, 0, target.z) * Move.player.speed);

    }

    private Vector3 GetNode()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                float distance = Vector3.Distance(grid[i, j], new Vector3(Move.player.transform.position.x, 0, Move.player.transform.position.z) + new Vector3(Move.player.direction.x, 0, Move.player.direction.z) * predictionLength);

                if (distance < snapRadius)
                {
                    return grid[i, j];
                }
            }
        }

        return Move.player.transform.position;
    }

    private void UpdateGrid()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                grid[i, j] = transform.position + new Vector3(-gapSize * gridSize + i * gapSize, 0, -gapSize * gridSize + j * gapSize);
            }
        }
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(grid[i, j], snapRadius);
            }
        }

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(grid[gridSize, gridSize], activeRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.target, snapRadius);
        Gizmos.DrawLine(Move.player.transform.position, Move.player.transform.position + new Vector3(Move.player.direction.x, 0, Move.player.direction.z) * predictionLength);
    }
}
