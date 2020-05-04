using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Toma llave");
        Destroy(this.gameObject);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.AddKey(id);
    }
}
