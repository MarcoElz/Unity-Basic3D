using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinText;
    public Text normalKeyText;
    public Text goldKeyText;

    int coins;

    int normalKeys; //id 1
    int goldKeys; // id 2

    public void AddCoin()
    {
        coins++;
        Debug.Log("Coins: " + coins);

        //Cambiar texto en pantalla
        coinText.text = "Coins: " + coins;
    }

    public void AddKey(int id)
    {
        if (id == 1)
        {
            normalKeys++;
            normalKeyText.text = "Normal Key: " + normalKeys;
        }
        else if (id == 2)
        {
            goldKeys++;
            goldKeyText.text = "Gold Key: " + goldKeys;
        }
        else
            Debug.LogWarning("No existe la llave con id: " + id);
    }

    public void ConsumeKey(int id)
    {
        if (id == 1)
        {
            normalKeys--;
            normalKeyText.text = "Normal Key: " + normalKeys;
        }
        else if (id == 2)
        {
            goldKeys--;
            goldKeyText.text = "Gold Key: " + goldKeys;
        }
        else
            Debug.LogWarning("No existe la llave con id: " + id);
    }

    public bool HasKey(int id)
    {
        int count = 0;

        if (id == 1)
            count = normalKeys;
        else if (id == 2)
            count = goldKeys;


        if (count > 0)
            return true;
        else
            return false;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
