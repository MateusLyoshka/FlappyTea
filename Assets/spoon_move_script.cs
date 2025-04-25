using UnityEngine;

public class pipe_move_script : MonoBehaviour
{
    public float moveSpeed = 5;

    public float deadZone = -7;
    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
