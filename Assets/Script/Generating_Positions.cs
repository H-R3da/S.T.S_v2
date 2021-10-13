using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generating_Positions : MonoBehaviour
{
    public Vector3 centerPoint = new Vector3(-1.158784f, 0.2955393f, 5.859375f);
    public Vector3[,] positionsArrays = new Vector3[5, 2];
    public float[] gap = new float[2];

    public Vector3 newPoint;

    // Start is called before the first frame update
    //why the fuck my commit won't work
    void Start()
    {
        positionsArrays[2, 0] = centerPoint;
        positionsArrays[2, 1] = centerPoint;
        gap[0] = 1.129216f;
        gap[1] = 0.6415393f;
        newPoint = new Vector3(centerPoint.x + gap[0], centerPoint.y + gap[1], centerPoint.z);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; i++)
            {
                positionsArrays[i, 2 + j + 1] = new Vector3(positionsArrays[i, 2].x - Mathf.Pow(i, -1) * (gap[0] * j + 1), positionsArrays[i, 2].y + (gap[1] * j + 1), positionsArrays[i, 2].z);
                positionsArrays[i, 2 + j + 1] = new Vector3(positionsArrays[i, 2].x + Mathf.Pow(i, -1) * (gap[0] * j + 1), positionsArrays[i, 2].y - (gap[0] * j + 1), positionsArrays[i, 2].z);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
