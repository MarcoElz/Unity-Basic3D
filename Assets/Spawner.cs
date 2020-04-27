using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 3f);
    }

    void Spawn()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        position.y = Random.Range(0.5f, 1f);
        position.x = Random.Range(-4f, 4f);
        position.z = 8.0f;
        Instantiate(prefab, position, Quaternion.identity);
    }
}
