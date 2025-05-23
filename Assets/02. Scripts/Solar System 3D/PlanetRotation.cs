using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;        // 공전을 하기 위한 타겟 게임 오브젝트

    public float rotSpeed = 30f;          // 자전 속도

    public float revolutionSpeed = 100f;  // 공전 속도

    public bool isRevolution = false;

    void Update()
    {
        // 자기 자신이 Y축을 기준으로 회전 <자전>
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true)
        {
            // 자기 자신이 타겟의 Y축을 기준으로 회전 <공전>
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }

}
