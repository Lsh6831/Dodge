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

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xinput * speed;
        float zSpeed = zinput * speed;
        float ySpeed = yinput * speed/4;
        //vector3 �ӵ��� (xSpeed,0f,zSpeed) ����
        Vector3 newvelocity = new Vector3(xSpeed, ySpeed, zSpeed);
        //     ���̸� �ƹ��ų���new �� ���� ����3 �ٽ� �Է��ϰ� ��ġ �Է�

        //������ٵ��� �������� ���� ���� ó���� �ƴ϶� -> �ӵ��� ���� ó��
        //������ �ٵ� �ӵ��� nowvelocity �Ҵ�
        playerRigidbody.velocity = newvelocity;

        //playerRigidbody.velocity += newvelocity;
        //�̰� ���� �ӵ�

        //������ ���
        //playerRigidbody.velocity = new Vector3(xinput * speed, 0f, zinput * speed);




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
    public void Die()
    {
        //�Ѵ°� True ���°� False
        my.SetActive(false);

        //���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� �����´�
        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
    
    
}
