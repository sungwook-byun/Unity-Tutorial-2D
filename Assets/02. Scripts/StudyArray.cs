using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{

    public int lever = 1;









  //  public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    int number = 1;
    private int number2 = 2;


    public int number3 = 3; // public이니 출력되는게 맞음

    [SerializeField] // 직렬화  - 인스펙터에 보이게 해줌
     private int number4 = 4; 

    [SerializeField] private int number5 = 5;



    /*    List<int> listNumber = new List<int>();



        void Start()
        {
            listNumber.Add(1);
            listNumber.Add(2);
            listNumber.Add(3);
            listNumber.Add(4);
            listNumber.Add(50);

            Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
            Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
        }
    */

}

