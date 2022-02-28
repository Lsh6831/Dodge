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

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xinput * speed;
        float zSpeed = zinput * speed;
        float ySpeed = yinput * speed/4;
        //vector3 속도를 (xSpeed,0f,zSpeed) 생성
        Vector3 newvelocity = new Vector3(xSpeed, ySpeed, zSpeed);
        //     ↑이름 아무거나↑new 꼭 쓰고 백터3 다시 입력하고 수치 입력

        //리지디바디의 물리적인 힘에 따른 처리가 아니라 -> 속도에 따른 처리
        //리지디 바디에 속도에 nowvelocity 할당
        playerRigidbody.velocity = newvelocity;

        //playerRigidbody.velocity += newvelocity;
        //이건 누적 속도

        //위에꺼 축약
        //playerRigidbody.velocity = new Vector3(xinput * speed, 0f, zinput * speed);




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
    public void Die()
    {
        //켜는건 True 끄는건 False
        my.SetActive(false);

        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져온다
        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
    
    
}
