using UnityEngine;

public class CubeCreate : MonoBehaviour
{

    public GameObject obj;

    public Mesh msh; // 메쉬 타입으로 변수 선언
    public Material mat; // 머티리얼 타입으로 변수 선언


    
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // 큐브 생성

        CreateCube(); // 큐브 생성 함수 호출
    }


    // 큐브를 생성하는 함수
    // 코드의 재사용성을 증가시키고 모듈화시킴
    // stirng 타입으로 name을 매개변수로 받아서 이름을 지정하며 디폴트 값을 "Cube"로 설정
    public void CreateCube(string name = "Cube")
    {
        // obj = new GameObject();
        // obj.name = "Cube";
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }

}
