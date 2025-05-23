using UnityEngine;

public class Movement2 : MonoBehaviour
{

    public float moveSpeed = 10f;  // �ʴ� �̵� �ӵ� (����Ƽ �⺻ ����)

    void Update()
    {

        float h = Input.GetAxis("Horizontal"); // A, D, ��, �� Ű
        float v = Input.GetAxis("Vertical"); // W, S, ��, �� Ű

        Vector3 dir = new Vector3(h, 0, v).normalized; // ���� ���͸� ����ȭ�Ͽ� ũ�⸦ 1�� ����
        Vector3 normalDir = dir.normalized; // ���� ���͸� ����ȭ�Ͽ� ũ�⸦ 1�� ����

        transform.position += dir * moveSpeed * Time.deltaTime; // �̵�

        transform.LookAt(transform.position + normalDir); // �ٶ󺸴� ������ �̵� �������� ����

    }
}
