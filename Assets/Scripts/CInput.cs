using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInput : MonoBehaviour
{
    public Vector3 dir;
    void Update()
    {
        //키보드의 입력을 받는다
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        dir = new Vector3(h, 0, v);
        Debug.Log(dir);
    }
}