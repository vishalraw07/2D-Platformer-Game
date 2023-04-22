using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int enemyDamage;
    [SerializeField] private HealthController _healthController;

       private void OnCollisionEnter2D(Collision2D other)    
    {
        
       if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            Damage();
        }
        
    }

    void Damage()
    {
        _healthController.playerHealth = _healthController.playerHealth - enemyDamage;
        _healthController.UpdateHealth();

    }
     
}
