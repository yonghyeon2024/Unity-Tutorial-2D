using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    void Update()
    {
        // 매 프레임마다 (1, 0, 0)씩 이동함
        // transform.forward: Bullet의 현재 위치
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
