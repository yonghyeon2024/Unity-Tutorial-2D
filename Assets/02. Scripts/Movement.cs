using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        // 현재 위치  = 현재 위치 + (0, 0, 1)
        // this.transform.position = this.transform.position + Vector3.forward;
    }

    void Update()
    {
        // transform.position = transform.position + Vector3.forward * moveSpeed;
     
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
