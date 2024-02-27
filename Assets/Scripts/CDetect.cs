using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDetect : MonoBehaviour
{
    private GameObject playerGo;
    private CSightVisualizer sightVisualizer;
    public Vector3 dir;

    private void Start()
    {
        playerGo = GameObject.Find("Player");
        sightVisualizer = GetComponent<CSightVisualizer>();
    }

    void Update()
    {
        //플레이어와 나와의 거리를 계산 (벡터의 뺄셈 : 방향과 거리)
        //Vector3 c = playerGo.transform.position - this.transform.position;
        //float distance = c.magnitude;
        float distance = Vector3.Distance(playerGo.transform.position , this.transform.position);

        if (sightVisualizer.radius >= distance)
        {
            Debug.Log("시야에 들어옴");
            Vector3 c = playerGo.transform.position - this.transform.position;
            dir = c.normalized;
        }
        else 
        {
            Debug.Log("시야에서 벗어남");
            dir = Vector3.zero; 
        }
    }
}