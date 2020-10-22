using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public class Material
    {
        public const string STANDARD = "Standard";
    }

    public class Math
    {
        public const float DEGREE_TO_RADIAN = (Mathf.PI / 180f);
        public const float RADIAN_TO_DEGREE = (180f / Mathf.PI);
    }

    public class VertexCount
    {
        public const int TRIANGLE     = 3;
        public const int HEXAGON      = 6;
        public const int HEXAGON_MESH = 12;
    }

    public class PolygonCount
    {
        public const int TRIANGLE     = 3;
        public const int HEXAGON      = 12;
        public const int HEXAGON_MESH = 60;
    }
}
