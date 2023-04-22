using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysController : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other)    
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            playerController.PickUpKey();
            Destroy(gameObject);
        }
    }
}
