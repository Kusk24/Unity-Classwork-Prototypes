using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10;

    private float spawnPosZ = 20;

private float startDelay = 2; 
private float spawnInterval = 1.5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRandomAnimal();
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
