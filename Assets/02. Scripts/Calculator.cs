using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2; // �������




    void Start()
    {
        int addResult = AddMethod(); // �Լ� ȣ���ؼ� int ������ ����

        int minusResult = MinusMethod(); 

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}"); // �Լ� ������� ������ ������ �ҷ��ͼ� ������� ���   

    }


    int AddMethod()
    {
        int result = number1 + number2; // ��������
        return result; // ������� ��ȯ
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        return result;
    }


}
