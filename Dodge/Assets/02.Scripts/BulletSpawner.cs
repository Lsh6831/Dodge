using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //생성할 탄알의 원본 프리팹
    public GameObject bulletPrefab;
    //최소 생성 주기
    public float spawnRateMin = 0.5f;
    //시간 값은 무조건 float 사용

    //최대대 생성 주기
    public float spawnRateMax = 3f;

    //실제 생성 주기
    private float spawnRate;
    //최근 생성 시점에서 지난 시간을 담아둘 곳
    private float timeAfterSpawn;

    // 발사할 대상
    private Transform target;
    void Start()
    {
        // 최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0;
        // 탄알 생성 간격을 spawnRatemin 과 spawnRatemax 사이에서 랜덤하게 지정하여 spawRate에 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);


        //platerController 컴포넌트를 가진 게임 오브젝트를 찾아서 그 오브젝트의 위치값을 가져와
        target = FindObjectOfType<PlayerController>().transform;


    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 길다면
        if(timeAfterSpawn >= spawnRate)
        {
            // bulletPrefab 의 복제본을 transform.position 위치와
            // tranform.rotation 회전으로 생성
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            //생선된 bullet 게임 오브젝트의 정면 방향이
            //traget을 향하도록 회전
            bullet.transform.LookAt(target);

            // 다음번 생성 간견을 spawnRateMin, spawnRateMax 사이에서 랜덤 지정
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //누적된시간 리셋
            timeAfterSpawn = 0f;
        
        
        }

        

        //Debug.Log(Time.deltaTime);
    }
}
