using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CMove : MonoBehaviour
{
    public void Move(Vector3 dir)
    {
        this.transform.Translate(dir * 1 * Time.deltaTime);
    }
}