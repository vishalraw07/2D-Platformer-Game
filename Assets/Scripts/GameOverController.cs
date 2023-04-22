using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;
    public Button buttonMainMenu;
   
  
    private void Awake()
    {
        Debug.Log("awaking");
        buttonRestart.onClick.AddListener(RestartGame);
        buttonMainMenu.onClick.AddListener(MainMenu);
         
    }
    
   public void PlayerDied()
    {
        SoundManager.Instance.PlayMusic(Sounds.PlayerDeath);
        gameObject.SetActive(true);
        Debug.Log("activating scene");
        
    }

    private void RestartGame()
    {
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
     private void MainMenu()
    {
        Debug.Log("Exting to main menu");
        SceneManager.LoadScene(0);
    }

    

}
