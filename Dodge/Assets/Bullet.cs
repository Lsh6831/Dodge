using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletrigidbody;
    // ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� blulletRigidbody �� �Ҵ�
        bulletrigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵��ӷ�;
        bulletrigidbody.velocity = transform.forward * speed;
        //                         ��ҹ��� t=���� �빮�� T=?,forward->vector3(x(0),y(0),z(1)), up,right �� ���� �ݴ�� *-1���

        Destroy(gameObject,3f);
        //���ı�           �������ð�

    }

    void Update()
    {
        
    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浿�� ���� ���� ������Ʈ�� Player �±׸� ��������?
        if(other.tag == "Player")
        {
            //����(�浿��) ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();
            //�������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if(playerController !=null)
            {
                //PlayerContyoller �����ͺz�� Die() �޼��� ����
                playerController.Die();
            }
        
        } 
    }
}
