using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    [SerializeField] private GameObject [] animalPrefabs;

    void Start() => InvokeRepeating(nameof(SpawnAnimal), 2, 2);
    
    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float xPosition = Random.Range(-15, 15);

        Instantiate(animalPrefabs[animalIndex], new(xPosition, 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}