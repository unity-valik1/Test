using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] prefabs;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, prefabs.Length);
            Vector2 SpawnPos = new Vector2(Random.Range(-14, 14), Random.Range(-8, 8));
            Instantiate(prefabs[randomNumber], SpawnPos, Quaternion.identity);
        }
    }
}
