using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
   public Button buttonPlay;
   public Button buttonQuit;
   public GameObject LevelSelection;
   private void Awake()
   {
        buttonPlay.onClick.AddListener(PlayGame);
        buttonQuit.onClick.AddListener(QuitGame);
   }

   private void PlayGame()
   {
          SoundManager.Instance.Play(Sounds.ButtonClick);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        LevelSelection.SetActive(true);
   }
    private void QuitGame()
   {
          Debug.Log("Application has stopped");
        Application.Quit();
   }
}
