using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public float curHealth = 0;
    public float maxHealth = 20;
    public float checkHealth = 0;
    public bool playerDeath = false;

    public HealthBar healthBar;

    void Start()
    {
        curHealth = 4;
    }

    void Update()
    {
     
    }

    public void DamagePlayer(float damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);

        if (curHealth > 0)
        {
            playerDeath = false;
        }
        else
        {
            playerDeath = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}