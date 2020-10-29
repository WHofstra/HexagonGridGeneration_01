using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : MeshGeneration
{
    //This class is created to test polygon/mesh generation
    protected override void Start()
    {
        base.Start();
        DrawMesh();
        SetMesh();
    }

    protected void DrawMesh()
    {
        vertices = new Vector3[Constants.VertexCount.TRIANGLE]
        {
            new Vector3(Mathf.Cos(0f), 0f, Mathf.Sin(0f)),
            new Vector3(Mathf.Cos(120 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(120 * Constants.Math.DEGREE_TO_RADIAN)),
            new Vector3(Mathf.Cos(240 * Constants.Math.DEGREE_TO_RADIAN), 0f, Mathf.Sin(240 * Constants.Math.DEGREE_TO_RADIAN))
        };

        normals = new Vector3[Constants.VertexCount.TRIANGLE] {
            -Vector3.forward, -Vector3.forward, -Vector3.forward
        };

        uvCoords = new Vector2[Constants.VertexCount.TRIANGLE] {
            new Vector2(0, 0), new Vector2(1, 0), new Vector2(1, 1)
        };

        tris = new int[Constants.PolygonCount.TRIANGLE] { 0, 2, 1 };
    }
}
