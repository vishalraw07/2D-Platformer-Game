using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int playerHealth;
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
            SceneManager.LoadScene(0);
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
