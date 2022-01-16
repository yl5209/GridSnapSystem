using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    public int gridSize;
    public float gridOffset;

    public float activeRadius;
    public float snapRadius;

    private Vector3[,] grid;
    private int size;

    private Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        size = gridSize * 2 + 1;
        grid = new Vector3[size, size];

        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                grid[i, j] = new Vector3(-gridOffset * 2 + i * gridOffset, 0, -gridOffset * 2 + j * gridOffset);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGrid();

        SnapPlayer();
    }

    private void SnapPlayer()
    {
        if (Move.player.isMoving)
            return;



        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                float distance = Vector3.Distance(grid[i, j], new Vector3(Move.player.transform.position.x, 0, Move.player.transform.position.z));

                if (distance < snapRadius && distance > 0.05f)
                {
                    Debug.Log("Checking");
                    Vector3 target = Vector3.SmoothDamp(Move.player.transform.position, grid[i, j], ref vel, 0.15f);
                    Move.player.DoMove(new Vector3(target.x, 0, target.z));
                }
            }
        }
    }

    private void UpdateGrid()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                grid[i, j] = new Vector3(-gridOffset * 2 + i * gridOffset, 0, -gridOffset * 2 + j * gridOffset);
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
    }
}
