using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    public EndLevel endLevel;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            /*
            //level is done
            Debug.Log("Level Completed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            */
            Debug.Log("Next Level is unlocked");
            //LevelManager.Instance.SetLevelStatus(SceneManager.GetActiveScene().name,LevelStatus.Completed);
            LevelManager.Instance.MarkCurrentLevelComplete();
            endLevel.CompletedLevel();
            
        }
        
   }
   
}
