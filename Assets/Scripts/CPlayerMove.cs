using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerMove : CMove
{
    private CInput cInput;
    private void Start()
    {
        cInput = GetComponent<CInput>();
    }

    private void Update()
    {
        Debug.Log("CPlayerMove의 Update: " + cInput.dir);
        Move(cInput.dir);
    }
}