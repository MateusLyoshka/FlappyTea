using UnityEngine;

public class cloud_spawn : MonoBehaviour
{
    public GameObject cloud;
    private float spawnRate;
    private float timerStart = 0;
    public float maxSpawnPos;
    public float minSpawnPos;
    void Start()
    {
        maxSpawnPos = transform.position.y + 0.5f;
        minSpawnPos = transform.position.y - 0.5f;
        print(transform.position.y);
        spawnRate = Random.Range(0.3f, 1.0f);
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(1.0f, 25.0f);
        print(spawnRate);
        if (timerStart < spawnRate)
        {
            timerStart += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timerStart = 0;
        }
    }

    void SpawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(minSpawnPos, maxSpawnPos), 0), Quaternion.identity);
    }
}
