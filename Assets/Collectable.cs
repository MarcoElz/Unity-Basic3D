using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        //Quaternion
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,rotationSpeed * Time.deltaTime,0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.AddCoin();
    }
}

