using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf; // ���ӿ�����Ʈ Ÿ�Ժ��� Ʈ������Ÿ���� �� ���� ��Ȳ�̶� Ÿ���̶�� ����
    public Transform turretHead; // ��ž�� �Ӹ� �κ��� ����Ű�� ����

    public GameObject bulletPrefab; // �Ѿ� �������� ����Ű�� ����
    public Transform firePos; // �߻���ġ

    public float timer;
    public float cooldownTime;


    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform.GetChild(0); // �±װ� Player�� ���ӿ�����Ʈ�� ã�Ƽ� Ÿ������ ����
    }

    void Update()
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // �Ѿ� ����
        }
    }
}
