using UnityEngine;

public class Study_Class
{
    public int number;

    // ������ : ������ �� ����Ǵ� �Լ�
    public Study_Class(int number)
    {
        this.number = number;
    }
}

public struct  Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}


public class Study_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Ŭ����-----------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1; // c1�� �ּҸ� c2�� ����
        c1.number = 100; // c1�� number�� 100���� ����

        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
        



        Debug.Log("����ü-----------------------");
        Study_Struct s1 = new Study_Struct(20);
        Study_Struct s2 = s1; // c1�� �ּҸ� c2�� ����
        s1.number = 200; // c1�� number�� 100���� ����

        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }
}
