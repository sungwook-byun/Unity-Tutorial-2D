using UnityEngine;

public class Movement : MonoBehaviour
{
  
    public float moveSpeed = 10f;  // �ʴ� �̵� �ӵ� (����Ƽ �⺻ ����)
    public float spinSpeed = 360f; // �ʴ� ȸ�� �ӵ� (�� ����)


    void Start()
    {
        // ������ġ = ������ġ + (5,5,5);
        // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;


        //Input System (Old - Legacy)
        // �Է°��� ���� ��ӵ� �ý���
        // �̵� -> WASD Ű, ȭ��ǥŰ
        // ���� -> �����̽���
        // �ѽ�� -> ���콺 ���ʹ�ư
/*
        // �ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal"); // A, D, ��, �� Ű
        float v = Input.GetAxis("Vertical"); // W, S, ��, �� Ű

*/


        // �� �������� ��
        float h = Input.GetAxisRaw("Horizontal"); // A, D, ��, �� Ű
        float v = Input.GetAxisRaw("Vertical"); // W, S, ��, �� Ű

        


        Vector3 dir = new Vector3 (h, 0, v);

        Vector3 normalDir = dir.normalized; // ���� ���͸� ����ȭ�Ͽ� ũ�⸦ 1�� ����

        
        Debug.Log($"���� �Է� : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime; // �̵�

    }
}
