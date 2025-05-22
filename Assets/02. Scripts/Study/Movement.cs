using UnityEngine;

public class Movement : MonoBehaviour
{
  
    public float moveSpeed = 10f;  // 초당 이동 속도 (유니티 기본 단위)
    public float spinSpeed = 360f; // 초당 회전 속도 (도 단위)


    void Start()
    {
        // 현재위치 = 현재위치 + (5,5,5);
        // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;


        //Input System (Old - Legacy)
        // 입력값에 대한 약속된 시스템
        // 이동 -> WASD 키, 화살표키
        // 점프 -> 스페이스바
        // 총쏘기 -> 마우스 왼쪽버튼
/*
        // 부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal"); // A, D, ←, → 키
        float v = Input.GetAxis("Vertical"); // W, S, ↑, ↓ 키

*/


        // 딱 떨어지는 값
        float h = Input.GetAxisRaw("Horizontal"); // A, D, ←, → 키
        float v = Input.GetAxisRaw("Vertical"); // W, S, ↑, ↓ 키

        


        Vector3 dir = new Vector3 (h, 0, v);

        Vector3 normalDir = dir.normalized; // 방향 벡터를 정규화하여 크기를 1로 만듦

        
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime; // 이동

    }
}
