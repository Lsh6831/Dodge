using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵� �ӷ�
    public float speed = 8f;

    // �� �ڽ��� ���� ����
    public GameObject my; 


    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();        
    }
    void Update()
    {
       //������� �������� �Է°��� �����ؼ� �����Ų��
       float xinput =Input.GetAxis("Horizontal");
        //Horizontal=����(x��)
        //Ű������ : 'A',���ʹ���Ű : ���ǹ��� : -1.0f
        //Ű������ : 'D' :,�����ʹ���Ű ���ǹ��� : +1.0f
        float zinput = Input.GetAxis("Vertical");
        //Vertical=����(z��)
        //Ű������ : 'W',���ʹ���Ű : ���ǹ��� : +1.0f
        //Ű������ : 'S',�Ʒ��ʹ���Ű : ���� ���� : -1.0f

        float yinput = Input.GetAxis("Jump");
    }




    void Directinput()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            //������ �ٵ� �ȿ� �ִ�(!) addforce
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
        //�Ѵ°� True ���°� False
        my.SetActive(false);
    }
    //void Life()
    //{
    //    //���̰� �ҹ��� Ȯ��
    //    gameObject.SetActive(true);
    //}    
    
}
