using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    // 이동 속력
    public float speed = 8f;

    // 내 자신을 담을 변수
    public GameObject my; 


    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아
        // playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();        
    }
    void Update()
    {
       //수평축과 수직축의 입력값을 감지해서 저장시킨다
       float xinput =Input.GetAxis("Horizontal");
        //Horizontal=수평(x값)
        //키보드의 : 'A',왼쪽방향키 : 음의방향 : -1.0f
        //키보드의 : 'D' :,오른쪽방향키 양의방향 : +1.0f
        float zinput = Input.GetAxis("Vertical");
        //Vertical=수직(z값)
        //키보드의 : 'W',윗쪽방향키 : 양의방향 : +1.0f
        //키보드의 : 'S',아래쪽방향키 : 음의 방향 : -1.0f

        float yinput = Input.GetAxis("Jump");
    }




    void Directinput()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            //리지드 바디 안에 있는(!) addforce
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Mouse0) == true)
        {
            playerRigidbody.AddForce(0f, 2f, 0f);
        }
    }
    void Die()
    {
        //켜는건 True 끄는건 False
        my.SetActive(false);
    }
    //void Life()
    //{
    //    //↓이거 소문자 확인
    //    gameObject.SetActive(true);
    //}    
    
}
