using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f; // 파괴될 시간


    // 시작할 때 1번 실행
    void Start()
    {
        Destroy(this.gameObject, destroyTime); 
        
    }

    // 파괴될 때 1번 실행
    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name} 이 파괴되었습니다.");
    }
}
