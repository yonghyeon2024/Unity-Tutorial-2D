using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;        // ������ �ϱ� ���� Ÿ�� ���� ������Ʈ

    public float rotSpeed = 30f;          // ���� �ӵ�

    public float revolutionSpeed = 100f;  // ���� �ӵ�

    public bool isRevolution = false;

    void Update()
    {
        // �ڱ� �ڽ��� Y���� �������� ȸ�� <����>
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true)
        {
            // �ڱ� �ڽ��� Ÿ���� Y���� �������� ȸ�� <����>
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }

}
