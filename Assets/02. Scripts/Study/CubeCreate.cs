using UnityEngine;

public class CubeCreate : MonoBehaviour
{

    public GameObject obj;

    public Mesh msh; // �޽� Ÿ������ ���� ����
    public Material mat; // ��Ƽ���� Ÿ������ ���� ����


    
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // ť�� ����

        CreateCube(); // ť�� ���� �Լ� ȣ��
    }


    // ť�긦 �����ϴ� �Լ�
    // �ڵ��� ���뼺�� ������Ű�� ���ȭ��Ŵ
    // stirng Ÿ������ name�� �Ű������� �޾Ƽ� �̸��� �����ϸ� ����Ʈ ���� "Cube"�� ����
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
