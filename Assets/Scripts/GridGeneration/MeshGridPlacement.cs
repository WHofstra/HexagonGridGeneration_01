using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGridPlacement : MonoBehaviour
{
    [SerializeField] GameObject _mesh;
    [SerializeField] Vector2 _gridLength;

    Vector3[,] grid;

    void Start()
    {
        InitGrid();
    }

    void InitGrid()
    {
        grid = new Vector3[(int)_gridLength.x, (int)_gridLength.y];

        grid[0, 0] = new Vector3(0f, 0f, 0f);
        Instantiate(_mesh, grid[0, 0], transform.rotation, transform);

        //Instantiate(_mesh, grid[1, 0], transform.rotation, transform);

        //for (int i = 0; i < 2; i++) {
        int i = 0;
            for (int j = 1; j < grid.GetLength(1); j++)
            {
                grid[i, j] = new Vector3(grid[i, (j - 1)].x + (2 * Mathf.Sin(60 * Constants.Math.DEGREE_TO_RADIAN)),
                                         grid[i, (j - 1)].y, grid[i, (j - 1)].z);
                Instantiate(_mesh, grid[i, j], transform.rotation, transform);
            }
        //}
    }
}
