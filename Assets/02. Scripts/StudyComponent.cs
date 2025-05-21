using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 게임오브젝트 타입으로 변수 선언  , Find 메서드를 사용하여 Main Camera 오브젝트를 찾아 obj 변수에 할당하기 때문에 굳이 public으로 선언할 필요는 없다. 

    public string changeName; // 문자열 타입으로 변수 선언



    void Start()
    {
        obj = GameObject.Find("Main Camera"); // FInd 메서드를 사용하여 Main Camera 오브젝트를 찾아 obj 변수에 할당 


        obj.name = changeName;
    }
}
