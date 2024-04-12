using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 center = Vector3.zero;
    public float size = 1f;
    public float circleRadius = 0.1f;
    public Vector3 translation = Vector3.zero;
    public Vector3 scale = Vector3.one;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        Vector3[] corners = new Vector3[8];
        corners[0] = center + new Vector3(-size, -size, -size);
        corners[1] = center + new Vector3(size, -size, -size) ;
        corners[2] = center + new Vector3(size, -size, size) ;
        corners[3] = center + new Vector3(-size, -size, size) ;
        corners[4] = center + new Vector3(-size, size, -size) ;
        corners[5] = center + new Vector3(size, size, -size) ;
        corners[6] = center + new Vector3(size, size, size) ;
        corners[7] = center + new Vector3(-size, size, size) ;

        for (int i = 0; i < corners.Length; i++)
        {
            corners[i] = Vector3.Scale(corners[i], scale) + translation;
        }

        for (int i = 0; i < 4; i++)
        {
            Gizmos.DrawLine(corners[i], corners[(i + 1) % 4]);
            Gizmos.DrawLine(corners[i + 4], corners[((i + 1) % 4) + 4]);
            Gizmos.DrawLine(corners[i], corners[i + 4]);
        }

        for (int i = 0; i < 4; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 4]);
        }

        Gizmos.color = Color.yellow;
        for (int i = 0; i < corners.Length; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(corners[i], circleRadius);
        }
    }
}
