using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;
  private float spawnRangeX = 20;
  private float spawnPosZ = 20;

  private float startDelay = 20;
  private float spawnInterval = 1.5f;

  void Start()
  {
    InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.S))
    {
      SpawnRandomAnimal();
    }
  }

  void SpawnRandomAnimal()
  {
    // Randomly generate animal index and spawn position
    var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    int animalIndex = Random.Range(0, animalPrefabs.Length);

    Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);

  }
}
