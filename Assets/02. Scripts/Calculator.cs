using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2; // 멤버변수




    void Start()
    {
        int addResult = AddMethod(); // 함수 호출해서 int 변수에 저장

        int minusResult = MinusMethod(); 

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}"); // 함수 결과값을 저장한 변수를 불러와서 결과값을 출력   

    }


    int AddMethod()
    {
        int result = number1 + number2; // 지역변수
        return result; // 결과값을 반환
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        return result;
    }


}
