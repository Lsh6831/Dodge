using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //������ ź���� ���� ������
    public GameObject bulletPrefab;
    //�ּ� ���� �ֱ�
    public float spawnRatemin = 0.5f;
    //�ð� ���� ������ float ���

    //�ִ�� ���� �ֱ�
    public float spawnRatemax = 3f;

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
        spawnRate = Random.Range(spawnRatemin, spawnRatemax);


        //platerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;


    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bulletPrefab);

    }
}
