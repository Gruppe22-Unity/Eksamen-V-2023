using UnityEngine;

public class IslandGenerator : MonoBehaviour
{
    public GameObject[] islandPrefabs;
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
            SpawnIsland();
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }

        MoveIslandsDown();
    }

    private void SpawnIsland()
    {
        int randomIndex = Random.Range(0, islandPrefabs.Length);
        GameObject islandPrefab = islandPrefabs[randomIndex];

        Vector3 spawnPosition = GetRandomSpawnPosition();
        GameObject island = Instantiate(islandPrefab, spawnPosition, Quaternion.identity);
        island.transform.SetParent(transform);
    }

    private void MoveIslandsDown()
    {
        foreach (Transform island in transform)
        {
            island.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
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