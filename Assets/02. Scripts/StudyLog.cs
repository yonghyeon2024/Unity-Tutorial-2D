using UnityEngine;

/// <summary>
/// ����Ƽ �����Ϳ� �ִ� Console View�� Log�� �׽�Ʈ�ϱ� ���� Ŭ����
/// </summary>
public class StudyLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start �Լ� ����");
        Debug.LogWarning("Start �Լ� ����");
        Debug.LogError("Start �Լ� ����");
    }

    void Update()
    {
    }
}