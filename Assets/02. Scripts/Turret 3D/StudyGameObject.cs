using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Awake()
    {
        CreateBrachio();
    }


    /// <summary>
    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>
    public void CreateBrachio()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "���Ű�� ĳ����";

        /*
                Transform objTf = obj.transform;

                Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {objTf.childCount}");

                Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

                Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(objTf.childCount - 1).name}");
        */
    }
}