using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMesh : MeshGeneration
{
    protected override void Start()
    {
        base.Start();
        DrawMesh();
    }

    protected void DrawMesh()
    {
        vertices = new Vector3[Constants.VertexCount.HEXAGON]
        {
            new Vector3(Mathf.Cos(30  * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(30  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(90  * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(90  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(150 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(150 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(210 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(210 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(270 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(270 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(330 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(330 * Constants.Math.DEGREE_TO_RADIAN))
        };

        normals = new Vector3[Constants.VertexCount.HEXAGON] 
        {
            -Vector3.forward, -Vector3.forward, -Vector3.forward,
            -Vector3.forward, -Vector3.forward, -Vector3.forward
        };

        uvCoords = new Vector2[Constants.VertexCount.HEXAGON]
        {
            new Vector2(0, 0), new Vector2(0, 0), new Vector2(1, 0),
            new Vector2(1, 1), new Vector2(1, 1), new Vector2(1, 0)
        };

        tris = new int[Constants.PolygonCount.HEXAGON] { 0, 5, 4, 0, 4, 3, 0, 3, 1, 1, 3, 2 };

        SetMesh();
    }
}
