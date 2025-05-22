using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f; // 총알속도

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime; // 총알이 앞으로 나아감. transform.forward로 하는 이유는 로컬의 정면을 기준으로 하기 때문
    }
}
