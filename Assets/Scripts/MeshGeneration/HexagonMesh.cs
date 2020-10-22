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
        vertices = new Vector3[Constants.VertexCount.HEXAGON_MESH]
        {
            new Vector3(Mathf.Cos(30  * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(30  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(90  * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(90  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(150 * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(150 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(210 * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(210 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(270 * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(270 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(330 * Constants.Math.DEGREE_TO_RADIAN),  0.5f, Mathf.Sin(330 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(30  * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(30  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(90  * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(90  * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(150 * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(150 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(210 * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(210 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(270 * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(270 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(330 * Constants.Math.DEGREE_TO_RADIAN), -0.5f, Mathf.Sin(330 * Constants.Math.DEGREE_TO_RADIAN))
        };

        normals = new Vector3[Constants.VertexCount.HEXAGON_MESH] 
        {
            -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward,
            -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward, -Vector3.forward
        };

        uvCoords = new Vector2[Constants.VertexCount.HEXAGON_MESH]
        {
            new Vector2(0, 0), new Vector2(0, 0), new Vector2(1, 0),
            new Vector2(1, 1), new Vector2(1, 1), new Vector2(0, 1),
            new Vector2(0, 0), new Vector2(0, 0), new Vector2(1, 0),
            new Vector2(1, 1), new Vector2(1, 1), new Vector2(0, 1)
        };

        tris = new int[Constants.PolygonCount.HEXAGON_MESH]
        {
            0,  5,  4,  0,  4,  3,  0,  3,  1,  1,  3,  2,   //Upper Hexagon
            0,  1,  7,  0,  7,  6,  1,  2,  8,  1,  8,  7,   //Sides
            2,  3,  9,  2,  9,  8,  3,  4, 10,  3, 10,  9,
            4,  5, 11,  4, 11, 10,  5,  0,  6,  5,  6, 11,
            6, 10, 11,  6,  9, 10,  6,  7,  9,  7,  8,  9    //Lower Hexagon
        };

        SetMesh();
    }
}
