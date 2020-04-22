using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiTrigger : MonoBehaviour
{
    public GameObject mySpotLight;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        mySpotLight.SetActive(true);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.GameWin();
    }

}
