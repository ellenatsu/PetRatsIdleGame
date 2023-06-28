using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsManager : MonoBehaviour
{
    public GameObject[] petPrefabs;

    public Pet curPet;

    public Transform canvas;

    public static PetsManager instance;

    void Awake(){

        instance = this;
    }

    public void SpawnPet(){
        //should add one judgement: if pet is full then won't spawn this one, and pet hunger gonna decrease as time goes
        GameObject petToSpawn = petPrefabs[Random.Range(0, petPrefabs.Length)];

        GameObject obj = Instantiate(petToSpawn, canvas);

        curPet = obj.GetComponent<Pet>();
    }

    public void ReplacePet(GameObject pet){
        Destroy(pet);
        SpawnPet();
    }
}
