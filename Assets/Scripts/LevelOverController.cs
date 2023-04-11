using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D collision)
   {
    
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            //level is done
            Debug.Log("Level Completed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        
   }
   
}
