using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGeneration : MonoBehaviour
{
    [SerializeField] protected Material _material;

    protected Mesh mesh;
    protected MeshRenderer rendr;
    protected MeshFilter filter;

    protected Vector3[] vertices;
    protected Vector3[] normals;
    protected Vector2[] uvCoords;
    protected int[] tris;

    virtual protected void Start()
    {
        rendr = gameObject.AddComponent<MeshRenderer>();
        filter = gameObject.AddComponent<MeshFilter>();

        rendr.sharedMaterial = new Material(Shader.Find(Constants.Material.STANDARD));
        mesh = new Mesh();

        rendr.material = _material;
    }

    protected void SetMesh()
    {
        mesh.vertices = vertices;
        mesh.triangles = tris;
        mesh.normals = normals;
        mesh.uv = uvCoords;

        filter.mesh = mesh;
    }
}
