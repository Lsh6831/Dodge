using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotationSpeed = 60f;

    void Update()
    {
        //������Ʈ �޼���� �Է°�(�Ű�����)�� X,Y,Z �࿡
        //���� ȸ������ �ް�, ���� ȸ�� ��Ÿ���� �Էµ�
        //����ŭ ��������� �� ȸ���մϴ�.
        transform. Rotate (0f,rotationSpeed*Time.deltaTime, 0f);   
    }
}
