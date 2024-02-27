using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterMove : CMove
{
    private CDetect cDetect;
    private void Start()
    {
        cDetect = GetComponent<CDetect>();
    }
}