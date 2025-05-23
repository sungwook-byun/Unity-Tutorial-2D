using UnityEngine; // UnityEngine ���ӽ����̽��� ����ϱ� ���� �߰�

public class StudyComponent : MonoBehaviour // ���������� public, Ŭ���� �̸� StudyComponent, MonoBehaviour Ŭ������ ��ӹ���
{
    private GameObject obj; // ���ӿ�����Ʈ Ÿ������ ���� ����  , Find �޼��带 ����Ͽ� Main Camera ������Ʈ�� ã�� obj ������ �Ҵ��ϱ� ������ ���� public���� ������ �ʿ�� ����. 

    public Transform objTf;
    
   // public string changeName; // ���ڿ� Ÿ������ ���� ����



    void Start() // private�� ������ voidŸ�� Start()�Լ�
    {
        //obj = GameObject.Find("Main Camera"); // FInd �޼��带 ����Ͽ� Main Camera ������Ʈ�� ã�� obj ������ �Ҵ� 
        obj = GameObject.FindGameObjectWithTag("Player"); // �±׸� ����Ͽ� Player �±׸� ���� ���� ������Ʈ�� ã�� obj ������ �Ҵ�

        objTf = GameObject.FindGameObjectWithTag("Player").transform; // �±׸� ����Ͽ� Player �±׸� ���� ���� ������Ʈ�� Transform ������Ʈ�� ã�� objTf ������ �Ҵ�

        Debug.Log($"��ġ : {obj.transform.position}"); // obj�� ��ġ�� �ֿܼ� ���

        obj.GetComponent<MeshRenderer>().enabled = false; // obj�� MeshRenderer ������Ʈ�� ��Ȱ��ȭ�Ͽ� ������Ʈ�� ������ �ʰ� ��

        obj.SetActive(false); // obj�� ��Ȱ��ȭ�Ͽ� ������Ʈ�� ������ �ʰ� ��


        /*
                Debug.Log($"�̸� : {obj.name}"); // obj�� �̸��� �ֿܼ� ���
                Debug.Log($"�±� : {obj.tag}"); // obj�� �±׸� �ֿܼ� ���
                Debug.Log($"��ġ : {obj.transform.position}"); // obj�� ��ġ�� �ֿܼ� ���
                Debug.Log($"ȸ�� : {obj.transform.rotation}"); // obj�� ȸ���� �ֿܼ� ���
                Debug.Log($"ũ�� : {obj.transform.localScale}"); // obj�� ���� �������� �ֿܼ� ���

                Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}"); // transform ������Ʈ�� �޽� �����͸� �ֿܼ� ���
                Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");  // transform ������Ʈ�� �޽� ������ �����͸� �ֿܼ� ���
        */


        // obj.name = changeName;
    }
}
