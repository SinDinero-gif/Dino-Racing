using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPlayer2 : MonoBehaviour
{
    public GameObject gameOverP2, heartP20, heartP21, heartP22, heartP23;
    public static int healthPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        healthPlayer2 = 4;
        heartP20.SetActive(true);
        heartP21.SetActive(true);
        heartP22.SetActive(true);
        heartP23.SetActive(true);
        gameOverP2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (healthPlayer2){

            case 4:
                heartP20.SetActive(true);
                heartP21.SetActive(true);
                heartP22.SetActive(true);
                heartP23.SetActive(true);
                break;
            case 3:
                heartP20.SetActive(true);
                heartP21.SetActive(true);
                heartP22.SetActive(true);
                heartP23.SetActive(false);
                break;
            case 2:
                heartP20.SetActive(true);
                heartP21.SetActive(true);
                heartP22.SetActive(true);
                heartP23.SetActive(false);
                break;
            case 1:
                heartP20.SetActive(true);
                heartP21.SetActive(true);
                heartP22.SetActive(false);
                heartP23.SetActive(false);
                break;
            case 0:
                heartP20.SetActive(true);
                heartP21.SetActive(false);
                heartP22.SetActive(false);
                heartP23.SetActive(false);
                break;
            default:
                heartP20.SetActive(false);
                heartP21.SetActive(false);
                heartP22.SetActive(false);
                heartP23.SetActive(false);
                gameOverP2.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
