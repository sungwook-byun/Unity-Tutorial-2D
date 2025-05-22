using UnityEngine; // UnityEngine 네임스페이스를 사용하기 위해 추가

public class StudyComponent : MonoBehaviour // 접근제한자 public, 클래스 이름 StudyComponent, MonoBehaviour 클래스를 상속받음
{
    private GameObject obj; // 게임오브젝트 타입으로 변수 선언  , Find 메서드를 사용하여 Main Camera 오브젝트를 찾아 obj 변수에 할당하기 때문에 굳이 public으로 선언할 필요는 없다. 

    public Transform objTf;
    
   // public string changeName; // 문자열 타입으로 변수 선언



    void Start() // private이 생략된 void타입 Start()함수
    {
        //obj = GameObject.Find("Main Camera"); // FInd 메서드를 사용하여 Main Camera 오브젝트를 찾아 obj 변수에 할당 
        obj = GameObject.FindGameObjectWithTag("Player"); // 태그를 사용하여 Player 태그를 가진 게임 오브젝트를 찾아 obj 변수에 할당

        objTf = GameObject.FindGameObjectWithTag("Player").transform; // 태그를 사용하여 Player 태그를 가진 게임 오브젝트의 Transform 컴포넌트를 찾아 objTf 변수에 할당

        Debug.Log($"위치 : {obj.transform.position}"); // obj의 위치를 콘솔에 출력

        obj.GetComponent<MeshRenderer>().enabled = false; // obj의 MeshRenderer 컴포넌트를 비활성화하여 오브젝트를 보이지 않게 함

        obj.SetActive(false); // obj를 비활성화하여 오브젝트를 보이지 않게 함


        /*
                Debug.Log($"이름 : {obj.name}"); // obj의 이름을 콘솔에 출력
                Debug.Log($"태그 : {obj.tag}"); // obj의 태그를 콘솔에 출력
                Debug.Log($"위치 : {obj.transform.position}"); // obj의 위치를 콘솔에 출력
                Debug.Log($"회전 : {obj.transform.rotation}"); // obj의 회전을 콘솔에 출력
                Debug.Log($"크기 : {obj.transform.localScale}"); // obj의 로컬 스케일을 콘솔에 출력

                Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}"); // transform 컴포넌트의 메쉬 데이터를 콘솔에 출력
                Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");  // transform 컴포넌트의 메쉬 렌더러 데이터를 콘솔에 출력
        */


        // obj.name = changeName;
    }
}
