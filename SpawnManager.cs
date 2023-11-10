using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs; 
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    public float startDelay = 20;
    public float  spawnInterval = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
   
    
    void Update()
    {
   
    }
     void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosZ = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, 10);
            Instantiate(animalPrefabs[animalIndex], spawnPosZ, animalPrefabs[animalIndex].transform.rotation);
     }

    


}
