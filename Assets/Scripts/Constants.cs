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
        public const float DEGREE_TO_RADIAN = (Mathf.PI / 180);
        public const float RADIAN_TO_DEGREE = (180 / Mathf.PI);
    }
}
