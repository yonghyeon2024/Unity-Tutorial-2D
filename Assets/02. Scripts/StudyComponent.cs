using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // 에디터에서 인스턴스(게임 오브젝트)를 담을 obj 포인터 변수
    public GameObject obj;  // GameObject: 자료형
    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
