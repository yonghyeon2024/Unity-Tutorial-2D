using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // �����Ϳ��� �ν��Ͻ�(���� ������Ʈ)�� ���� obj ������ ����
    public GameObject obj;  // GameObject: �ڷ���
    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
