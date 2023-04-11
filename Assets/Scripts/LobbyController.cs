using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
   public Button buttonPlay;
   public Button buttonQuit;
   private void Awake()
   {
        buttonPlay.onClick.AddListener(PlayGame);
        buttonQuit.onClick.AddListener(QuitGame);
   }

   private void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
    private void QuitGame()
   {
          Debug.Log("Application has stopped");
        Application.Quit();
   }
}
