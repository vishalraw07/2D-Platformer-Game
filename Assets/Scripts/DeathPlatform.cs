using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlatform : MonoBehaviour
{
    
     
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("player dies by the death floor");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   
}
