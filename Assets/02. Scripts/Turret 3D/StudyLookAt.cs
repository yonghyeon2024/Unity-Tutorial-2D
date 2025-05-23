using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;       // Ÿ�� ��ġ
    public Transform turretHead;

    public GameObject bulletPrefab;  // �Ѿ�
    public Transform firePos;        // �߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start()
    {
        // Ÿ���� ��ġ
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // turretHead�� Ÿ���� ��ġ�� �ٶ󺸰� ����
        turretHead.LookAt(targetTf);

        // timer
        timer += Time.deltaTime;

        // timer�� cooldownTime���� Ŀ�� ���
        if (timer >= cooldownTime)
        {
            timer = 0f;

            // (���� ���, ���� ��ġ, ȸ�� ����)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
