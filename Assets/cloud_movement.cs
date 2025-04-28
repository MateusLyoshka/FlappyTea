using UnityEngine;

public class cloud_movement : MonoBehaviour
{
    public float moveSpeed = 1;
    private float deadPoint = -7.3f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < deadPoint)
        {
            Destroy(gameObject);
        }
    }
}
