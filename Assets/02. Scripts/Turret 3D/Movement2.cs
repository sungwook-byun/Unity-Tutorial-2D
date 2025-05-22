using UnityEngine;

public class Movement2 : MonoBehaviour
{

    public float moveSpeed = 10f;  // 초당 이동 속도 (유니티 기본 단위)

    void Update()
    {

        float h = Input.GetAxis("Horizontal"); // A, D, ←, → 키
        float v = Input.GetAxis("Vertical"); // W, S, ↑, ↓ 키

        Vector3 dir = new Vector3(h, 0, v).normalized; // 방향 벡터를 정규화하여 크기를 1로 만듦
        Vector3 normalDir = dir.normalized; // 방향 벡터를 정규화하여 크기를 1로 만듦

        transform.position += dir * moveSpeed * Time.deltaTime; // 이동

        transform.LookAt(transform.position + normalDir); // 바라보는 방향을 이동 방향으로 설정

    }
}
