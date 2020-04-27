using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject puerta;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Toma llave");
        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);

    }

}
