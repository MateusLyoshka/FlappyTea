using UnityEngine;

public class spoon_spawn : MonoBehaviour
{
    public GameObject spoon;
    public float spawnRate = 2;
    private float timer = 0;
    public float hightOffset = 1;

    void Start()
    {
        spawnPipe();
    }


    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;
        Instantiate(spoon, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
