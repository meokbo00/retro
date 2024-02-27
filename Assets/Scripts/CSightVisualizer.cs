using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSightVisualizer : MonoBehaviour
{
    public float radius = 3;
    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, this.transform.forward, 360, radius);
    }
}