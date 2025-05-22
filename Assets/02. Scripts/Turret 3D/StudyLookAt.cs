using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf; // 게임오브젝트 타입보다 트랜스폼타입이 더 편한 상황이라 타겟이라는 변수
    public Transform turretHead; // 포탑의 머리 부분을 가리키는 변수

    public GameObject bulletPrefab; // 총알 프리팹을 가리키는 변수
    public Transform firePos; // 발사위치

    public float timer;
    public float cooldownTime;


    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform.GetChild(0); // 태그가 Player인 게임오브젝트를 찾아서 타겟으로 설정
    }

    void Update()
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // 총알 생성
        }
    }
}
