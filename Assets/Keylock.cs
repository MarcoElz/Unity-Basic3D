using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keylock : MonoBehaviour
{
    public GameObject door;

    public int id;

    bool isDoorOpen;

    public void OpenDoor()
    {
        //Cambiar rotacion de puerta para que se abra
        door.transform.Rotate(0f, 90f, 0f);
        //door.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isDoorOpen)
        {
            Debug.Log("Trigger con keylock");

            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager.HasKey(id) || id < 0)
            {
                gameManager.ConsumeKey(id); //Usar llave
                OpenDoor();
                isDoorOpen = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
