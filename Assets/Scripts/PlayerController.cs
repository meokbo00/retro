using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MonsterController[] monsters;

    void Start()
    {
        List<MonsterController> list = new List<MonsterController>();

        //배열의 요소 출력하기 
        for (int i = 0; i < monsters.Length; i++)
        {
            //배열의 요소 접근 
            MonsterController controller = monsters[i];
            //나와 거리를 계산하기 
            float distance = Vector3.Distance(this.transform.position, controller.transform.position);
            if (distance <= 8)
            {
                //Debug.LogFormat("{0} -> {1}", controller.gameObject.name, distance);
                list.Add(controller);
            }
        }

        //리스트 안에는 시야 안에 있는 몬스터 컨트롤러들만 있음 
        for (int i = 0; i < list.Count; i++)
        {
            MonsterController controller = list[i];
            float distance = Vector3.Distance(this.transform.position, controller.transform.position);
            Debug.LogFormat("<color=cyan>{0}</color> : {1}", controller.gameObject.name, distance);
        }

        float nearestDistance = Mathf.Infinity;
        MonsterController nearest = null;

        for (int i = 0; i < list.Count; i++)
        {
            MonsterController controller = list[i];
            float distance = Vector3.Distance(this.transform.position, controller.transform.position);
            if (distance < nearestDistance)
            {
                nearest = controller;
                nearestDistance = distance;
            }
        }

        Debug.LogFormat("<color=yellow>{0}</color> : {1}", nearest.gameObject.name, nearestDistance);
    }
}