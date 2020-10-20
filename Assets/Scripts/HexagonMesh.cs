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
        vertices = new Vector3[6]
        {
            new Vector3(Mathf.Cos(30  * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(30  * Constants.Math.DEGREE_TO_RADIAN), 0f),
            new Vector3(Mathf.Cos(90  * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(90  * Constants.Math.DEGREE_TO_RADIAN), 0f),
            new Vector3(Mathf.Cos(150 * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(150 * Constants.Math.DEGREE_TO_RADIAN), 0f),
            new Vector3(Mathf.Cos(210 * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(210 * Constants.Math.DEGREE_TO_RADIAN), 0f),
            new Vector3(Mathf.Cos(270 * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(270 * Constants.Math.DEGREE_TO_RADIAN), 0f),
            new Vector3(Mathf.Cos(330 * Constants.Math.DEGREE_TO_RADIAN), Mathf.Sin(330 * Constants.Math.DEGREE_TO_RADIAN), 0f)
        };

        tris = new int[12] { 0, 1, 5, 1, 4, 5, 1, 2, 4, 2, 3, 4 };

        normals = new Vector3[6]
        {
            -Vector3.forward, -Vector3.forward, -Vector3.forward,
            -Vector3.forward, -Vector3.forward, -Vector3.forward
        };

        mesh.vertices = vertices;
        mesh.triangles = tris;
        mesh.normals = normals;
    }
}
