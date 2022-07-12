using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(
            animalPrefabs[animalIndex],
            new Vector3(Random.Range(-20, 20), 0, 20),
            animalPrefabs[animalIndex].transform.rotation
        );
    }
}
