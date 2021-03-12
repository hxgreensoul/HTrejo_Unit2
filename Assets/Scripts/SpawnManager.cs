using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 13; 

    // Start is called before the first frame update
    void Start()
    {
        //calls-runs function, seconds, how fast generate animal
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f); 
        
    }

    // Update is called once per frame
    void Update() // happens only when needed, random - computational pwr
    {

 
    }
    //declares a function
    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length); //generates different animals
        Vector3 randPos = new Vector3(randXPos, 0, 21);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos, animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
