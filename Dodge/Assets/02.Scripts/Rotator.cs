using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotationSpeed = 60f;

    void Update()
    {
        //로테이트 메서드는 입력값(매개변수)로 X,Y,Z 축에
        //대한 회전값을 받고, 현재 회전 상타에서 입력된
        //값만큼 상대적으로 더 회전합니다.
        transform. Rotate (0f,rotationSpeed*Time.deltaTime, 0f);   
    }
}
