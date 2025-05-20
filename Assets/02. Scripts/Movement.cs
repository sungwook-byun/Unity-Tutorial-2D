using UnityEngine;

public class Movement : MonoBehaviour
{
  
    public float moveSpeed = 10f;


    void Start()
    {
        // 현재위치 = 현재위치 + (5,5,5);
        // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 앞으로 가는 기능
        if(Input.GetKey(KeyCode.W)) 
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        // 뒤로 가는 기능
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        // 왼쪽으로 가는 기능
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        // 오른쪽으로 가는 기능
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
