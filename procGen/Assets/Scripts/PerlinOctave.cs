using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinOctave : MonoBehaviour
{
    float gradient[][][2];
    int size;

    private void PerlinOctave(int size)
    {
        this.size = size;

        gradient = new float[size + 1][size + 1][2];
        for (int ix = 0; ix <= size; ix++)
        {
            for (int iy = 0; iy <= size; iy++)
            {
                gradient[ix][iy][0] = randomRange(-1, 1);
                gradient[ix][iy][1] = randomRange(-1, 1);
            }
        }
    }
}
