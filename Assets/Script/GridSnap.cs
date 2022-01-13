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

    // Start is called before the first frame update
    void Start()
    {
        int size = gridSize * 2 + 1;
        grid = new Vector3[size, size];

        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                grid[i,j] = new Vector3()
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
