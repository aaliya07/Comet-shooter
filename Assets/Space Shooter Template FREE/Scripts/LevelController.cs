using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Serializable classes
[System.Serializable]
public class EnemyWaves 
{
    public GameObject wave; // Enemy wave prefab
    public float spawnInterval = 5.0f; // Interval between waves
}

#endregion

public class LevelController : MonoBehaviour 
{
    public EnemyWaves[] enemyWaves; // Array of enemy waves
    public GameObject powerUpPrefab; // Power-up prefab
    public float powerUpSpawnInterval = 30.0f; // Interval for power-up spawning

    void Start()
    {
        StartCoroutine(SpawnEnemiesInfiniteLoop());
        StartCoroutine(SpawnPowerUps());
    }

    IEnumerator SpawnEnemiesInfiniteLoop()
    {
        while (true)
        {
            foreach (var wave in enemyWaves)
            {
                Instantiate(wave.wave, GetRandomSpawnPosition(), Quaternion.identity);
                yield return new WaitForSeconds(wave.spawnInterval);
            }
        }
    }

    IEnumerator SpawnPowerUps()
    {
        while (true) // A continuous loop, typical for a coroutine
        {
            yield return new WaitForSeconds(powerUpSpawnInterval); // Wait for the specified interval

           Vector3 spawnPosition = GetRandomSpawnPosition(); // Calculate spawn position
        Debug.Log("Spawning power-up at " + spawnPosition); // Log the spawn position for debugging
        Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity); // Instantiate the power-up prefab
            
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Implement logic to get a random position for spawning
        // Example position range, adjust according to your game world
        return new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
    }

    // Add other existing methods or logic here...
}
