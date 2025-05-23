using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;       // 타겟 위치
    public Transform turretHead;

    public GameObject bulletPrefab;  // 총알
    public Transform firePos;        // 발사 위치

    public float timer;
    public float cooldownTime;

    void Start()
    {
        // 타겟의 위치
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // turretHead가 타겟의 위치를 바라보게 설정
        turretHead.LookAt(targetTf);

        // timer
        timer += Time.deltaTime;

        // timer가 cooldownTime보다 커질 경우
        if (timer >= cooldownTime)
        {
            timer = 0f;

            // (생성 대상, 생성 위치, 회전 상태)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
