using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGridPlacement : MonoBehaviour
{
    [SerializeField] GameObject _mesh;
    [SerializeField] Vector2 _gridLength;

    Vector3[,] grid;
    float hexAngle;

    void Start()
    {
        InitGrid();
    }

    void InitGrid()
    {
        grid = new Vector3[(int)_gridLength.x, (int)_gridLength.y];
        hexAngle = Mathf.Sin(60 * Constants.Math.DEGREE_TO_RADIAN);

        grid[0, 0] = new Vector3(transform.position.x - (hexAngle * (grid.GetLength(0) - 0.5f)),
                                 transform.position.y, transform.position.z + (Mathf.Pow(hexAngle, 2) *
                                (grid.GetLength(1) - 1)));

        grid[0, 1] = new Vector3(grid[0, 0].x + (Mathf.Cos(60 * Constants.Math.DEGREE_TO_RADIAN) * hexAngle * 2),
                                 transform.position.y, grid[0, 0].z - (Mathf.Pow(hexAngle, 2) * 2));

        for (int i = 2; i < grid.GetLength(1); i++)
        {
            grid[0, i] = new Vector3(grid[0, (i - 2)].x, transform.position.y,
                                     grid[0, (i - 2)].z - (Mathf.Pow(Mathf.Sin(60 * Constants.Math.DEGREE_TO_RADIAN), 2) * 4));
        }

        for (int i = 0; i < grid.GetLength(1); i++) {
            for (int j = 1; j < grid.GetLength(0); j++)
            {
                grid[j, i] = new Vector3(grid[(j - 1), i].x + (2 * hexAngle),
                                         transform.position.y, grid[(j - 1), i].z);
            }
        }

        for (int i = 0; i < grid.GetLength(1); i++) {
            for (int j = 0; j < grid.GetLength(0); j++)
            {
                Instantiate(_mesh, grid[j, i], transform.rotation, transform);
            }
        }
    }
}
