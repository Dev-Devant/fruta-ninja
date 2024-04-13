using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

    public GameObject[] items;
    private int round = 1;

    void Start()    {
        InvokeRepeating("SpawnerEando",3,2);
    }

    void Update()    {
        
    }

    void SpawnerEando(){
        for(int i = 0;i< round;i++) {
            int index = Random.Range(0,items.Length);
            float x = Random.Range(-5.0f,5.0f);
            Vector3 spawnPos = transform.position + new Vector3(x,0,0);
            Instantiate(items[index],spawnPos,transform.rotation);
        }
        round += 1;
    }
}
