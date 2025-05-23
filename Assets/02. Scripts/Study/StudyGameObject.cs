using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Awake()
    {
        CreateAmongus();  // 생성
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";
    }
}
