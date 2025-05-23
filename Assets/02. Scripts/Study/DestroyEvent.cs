using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f; // �ı��� �ð�


    // ������ �� 1�� ����
    void Start()
    {
        Destroy(this.gameObject, destroyTime); 
        
    }

    // �ı��� �� 1�� ����
    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name} �� �ı��Ǿ����ϴ�.");
    }
}
