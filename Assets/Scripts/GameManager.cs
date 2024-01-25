using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver, heart0, heart1, heart2, heart3;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        heart0.SetActive(true);
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (health){

            case 4:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;
            case 3:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;
            case 2:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;
            case 1:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            case 0:
                heart0.SetActive(true);
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            default:
                heart0.SetActive(false);
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                gameOver.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
