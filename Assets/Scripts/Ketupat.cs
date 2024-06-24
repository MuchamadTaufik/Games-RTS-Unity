using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ketupat : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Player.numberOfCoins++;
            PlayerPrefs.SetInt("NumberOfCoins", Player.numberOfCoins);
            Destroy(gameObject);
        }
    }

}
