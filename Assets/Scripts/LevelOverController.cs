using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{

    //GameManager gm;

    //public string LevelName;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    
        if(collision.gameObject.CompareTag("Player"))
        {
            //Level is over
             Debug.Log("Level Completed");
            SceneManager.LoadScene(1);
        } 
/*
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            //level is done
            Debug.Log("Level Completed");
            SceneManager.LoadScene(1);
        }
        */
   }

  
   
}
