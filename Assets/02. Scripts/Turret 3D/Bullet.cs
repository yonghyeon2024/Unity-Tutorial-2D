using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    void Update()
    {
        // �� �����Ӹ��� (1, 0, 0)�� �̵���
        // transform.forward: Bullet�� ���� ��ġ
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
