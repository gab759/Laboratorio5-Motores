using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCoordinates : MonoBehaviour
{
    public float size = 1f;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * size);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.up * size);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * size);
    }
}
