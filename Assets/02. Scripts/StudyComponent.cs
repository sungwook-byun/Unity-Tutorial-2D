using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ���ӿ�����Ʈ Ÿ������ ���� ����  , Find �޼��带 ����Ͽ� Main Camera ������Ʈ�� ã�� obj ������ �Ҵ��ϱ� ������ ���� public���� ������ �ʿ�� ����. 

    public string changeName; // ���ڿ� Ÿ������ ���� ����



    void Start()
    {
        obj = GameObject.Find("Main Camera"); // FInd �޼��带 ����Ͽ� Main Camera ������Ʈ�� ã�� obj ������ �Ҵ� 


        obj.name = changeName;
    }
}
