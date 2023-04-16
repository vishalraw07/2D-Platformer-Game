using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int playerHealth;
    public GameOverController gameOverController;
    public PlayerController playerController;
    [SerializeField] private Image[] hearts;

    

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("Player is dead");
            playerController.KillPlayer();
        }

        for(int i=0; i < hearts.Length; i++)
        {
            if( i < playerHealth)
            {
                Debug.Log("RED");
                hearts[i].color = Color.red;
            }
            else
            {
                Debug.Log("black");
                hearts[i].color = Color.black;
            }
        }
    }

}
