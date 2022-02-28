using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    private Rigidbody bulletrigidbody;
    // 탄알 이동 속력
    public float speed = 8f;

    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 blulletRigidbody 에 할당
        bulletrigidbody = GetComponent<Rigidbody>();

        //리지드바디의 속도 = 앞쪽 방향 * 이동속력;
        bulletrigidbody.velocity = transform.forward * speed;
        //                         ↑소문자 t=변수 대문자 T=?,forward->vector3(x(0),y(0),z(1)), up,right 도 존재 반대는 *-1사용

        Destroy(gameObject,3f);
        //↑파괴           ↑지연시간

    }

    void Update()
    {
        
    }

    //트리거 충돌 시 자동으로 실행되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        //충동한 상대방 게임 오브젝트가 Player 태그를 가졌나요?
        if(other.tag == "Player")
        {
            //상대방(충동한) 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();
            //상대방으로부터 PlayerController 컴포넌트를 가져오는데 성공했다면
            if(playerController !=null)
            {
                //PlayerContyoller 컴포넌틑의 Die() 메서드 실행
                playerController.Die();
            }
        
        } 
    }
}
