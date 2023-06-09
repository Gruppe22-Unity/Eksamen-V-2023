using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public float scrollSpeed = 1f;

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }

        MoveEnemiesDown();
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject enemyPrefab = enemyPrefabs[randomIndex];

        Vector3 spawnPosition = GetRandomSpawnPosition();
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        enemy.transform.SetParent(transform);
    }

    private void MoveEnemiesDown()
    {
        foreach (Transform enemy in transform)
        {
            enemy.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        float spawnX = Random.Range(-7f, 7f);
        float spawnY = Random.Range(15f, 20f);
        float spawnZ = 0f;

        return new Vector3(spawnX, spawnY, spawnZ);
    }
}


