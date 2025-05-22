using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        CreateAmongus();  // ����
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� ��: {count}");
        Debug.Log($"ĳ������ ù ��° �ڽ� ������Ʈ�� �̸�: {objTf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸�: {objTf.GetChild(count - 1).name}");
    }
}
