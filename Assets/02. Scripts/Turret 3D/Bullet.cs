using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f; // �Ѿ˼ӵ�

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime; // �Ѿ��� ������ ���ư�. transform.forward�� �ϴ� ������ ������ ������ �������� �ϱ� ����
    }
}
