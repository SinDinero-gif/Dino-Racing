using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject Coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") {

            CoinManager.coinCount += 1;
            Debug.Log("Coins:" + CoinManager.coinCount);
            Destroy(Coin);
        }
    }
}
