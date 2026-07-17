using UnityEngine;

public class LogSpawnerScrip : MonoBehaviour
{
    public GameObject log;
    public float spawnRate;
    public float timer;
    public float heightOffset;
    void Start()
    {
        SpawnLog();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnLog();
            timer = 0;  
        }
    }

    void SpawnLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(log, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
