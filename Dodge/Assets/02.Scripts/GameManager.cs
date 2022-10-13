using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI���� ���̺귯�� ���
using UnityEngine.UI;
// �� ���� ���̺귯�� ���
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ 
    public GameObject gameOverText;
    //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI timeText;
    //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI recordText;
    //���� �����ð�
    private float surviveTime;
    //���ӿ��� ����
    private bool isGameOver;


    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameOver = false;

        
    }
    void Update()
    {
      //���� �������� ���� Ȯ��
      if(!isGameOver)
        {
            //���� �ð� ����
            surviveTime += Time.deltaTime;
            //������ ���� �ð��� time text ������Ʈ�� ����� ǥ��
            timeText.text = "Time : " + (int)surviveTime;
        }
      else
        {
            // ���� ���� ���¿��� RŰ������ ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���¸� ��ȯ
        isGameOver = true;

    }
}
