using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI관련 라이브러리 사용
using UnityEngine.UI;
// 씬 관련 라이브러리 사용
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //게임오버 시 활성화할 텍스트 게임 오브젝트 
    public GameObject gameOverText;
    //생존 시간을 표시할 텍스트 컴포넌트
    public TextMeshProUGUI timeText;
    //최고 기록을 표시할 텍스트 컴포넌트
    public TextMeshProUGUI recordText;
    //실제 생존시간
    private float surviveTime;
    //게임오버 상태
    private bool isGameOver;


    void Start()
    {
        //생존 시간과 게임오버 상태 초기화
        surviveTime = 0f;
        isGameOver = false;

        
    }
    void Update()
    {
      //게임 오버상태 인지 확인
      if(!isGameOver)
        {
            //생존 시간 갱신
            surviveTime += Time.deltaTime;
            //갱신한 생존 시간을 time text 컴포넌트를 사용해 표시
            timeText.text = "Time : " + (int)surviveTime;
        }
      else
        {
            // 게임 오버 상태에서 R키를누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene 로드
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    //현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        //현재 상태를 게임오버 상태를 전환
        isGameOver = true;

    }
}
