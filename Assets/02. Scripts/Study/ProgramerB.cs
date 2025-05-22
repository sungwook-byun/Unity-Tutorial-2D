using UnityEngine;
using DevA;


public class ProgramerB : MonoBehaviour
{
    public ProgramerA pA; // ProgramerA클래스타입을 받는 변수 pA를 public으로 선언
                          
    void Start()
    {
      //  pA.number1 = 10;

        pA.number2 = 20;

      /*  pA.number3 = 30;

        pA.number4 = 40;

        pA.number5 = 50;*/
    }
}
