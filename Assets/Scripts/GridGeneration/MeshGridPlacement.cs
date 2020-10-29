using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGridPlacement : MonoBehaviour
{
    [SerializeField] GameObject _mesh;
    [SerializeField] Vector2 _gridLength;

    Vector3[] gridPosition = new Vector3[2];
    float offset;
    float hexAngle;
    bool getOffset;

    void Start()
    {
        InitGrid();
    }

    void InitGrid()
    {
        getOffset = false;
        hexAngle = Mathf.Sin(60 * Constants.Math.DEGREE_TO_RADIAN);
        gridPosition[0] = new Vector3(transform.position.x - (hexAngle * (_gridLength.x - 0.5f)),
                                      transform.position.y, transform.position.z + (Mathf.Pow(hexAngle, 2) *
                                     (_gridLength.y - 1)));
        offset = Mathf.Cos(60 * Constants.Math.DEGREE_TO_RADIAN) * hexAngle * 2;

        for (int i = 0; i < _gridLength.y; i++) {
            for (int j = 0; j < _gridLength.x; j++)
            {
                gridPosition[1] = new Vector3(gridPosition[0].x + (j * 2 * hexAngle), transform.position.y,
                                                  gridPosition[0].z - (i * Mathf.Pow(Mathf.Sin(60 * Constants.Math.DEGREE_TO_RADIAN), 2) * 2));

                if (getOffset) gridPosition[1].x += offset;
                Instantiate(_mesh, gridPosition[1], transform.rotation, transform);
            }
            getOffset = !getOffset;
        }
    }
}
