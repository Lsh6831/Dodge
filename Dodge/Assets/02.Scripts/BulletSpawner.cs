using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //������ ź���� ���� ������
    public GameObject bulletPrefab;
    //�ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    //�ð� ���� ������ float ���

    //�ִ�� ���� �ֱ�
    public float spawnRateMax = 3f;

    //���� ���� �ֱ�
    private float spawnRate;
    //�ֱ� ���� �������� ���� �ð��� ��Ƶ� ��
    private float timeAfterSpawn;

    // �߻��� ���
    private Transform target;
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0;
        // ź�� ���� ������ spawnRatemin �� spawnRatemax ���̿��� �����ϰ� �����Ͽ� spawRate�� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);


        //platerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;


    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ��ٸ�
        if(timeAfterSpawn >= spawnRate)
        {
            // bulletPrefab �� �������� transform.position ��ġ��
            // tranform.rotation ȸ������ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            //������ bullet ���� ������Ʈ�� ���� ������
            //traget�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            // ������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //�����Ƚð� ����
            timeAfterSpawn = 0f;
        
        
        }

        

        //Debug.Log(Time.deltaTime);
    }
}
