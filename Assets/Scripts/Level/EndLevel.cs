using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Button nextLevel;
    public Button levelSelection;
     public GameObject completeLevelUI;

    private void Awake()
    {
        nextLevel.onClick.AddListener(NextLevel);
        levelSelection.onClick.AddListener(LevelSelectionMenu);
    }
    private void NextLevel()
    {
        Debug.Log("Next level...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
     private void LevelSelectionMenu()
    {
        Debug.Log("Exting to Level Selection Menu");
        SceneManager.LoadScene(0);
    }
    public void CompletedLevel()
    {
        Debug.Log("Level Completed...");
        completeLevelUI.SetActive(true);
    }
}
