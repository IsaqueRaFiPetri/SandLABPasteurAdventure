using UnityEngine;

public class SpawObjectsRandomly : MonoBehaviour
{
    public GameObject objectToSpawn; // The object you want to spawn
    public int numberOfObjects = 1; // Number of objects to spawn
    public Vector2 spawnAreaCenter = Vector2.zero; // Center of the spawning area
    public Vector2 spawnAreaSize = new Vector2(10f, 10f); // Size of the spawning area

    private void Start()
    {
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector2 spawnPosition = GetRandomSpawnPosition();
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }

    private Vector2 GetRandomSpawnPosition()
    {
        Vector2 randomPosition = spawnAreaCenter + new Vector2(
            Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
            Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f)
        );

        return randomPosition;
    }
}
