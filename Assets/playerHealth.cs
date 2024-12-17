using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float maxHealth = 100;
    [SerializeField] movement dead;
    public bool deadBool = false;
    float currentHealth;
    [SerializeField] UnityEngine.UI.Image image;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (deadBool == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        }
    }
    public void takeDamage(float amount)
    {
        currentHealth -= amount;
        image.fillAmount -= amount/100;   //la division es para normalizar el daño en el rango de 1 para el fillamount
        if(currentHealth <= 0)
        {
            dead.dead();
            deadBool = true;
            
        }
    }
}
