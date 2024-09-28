using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagane : MonoBehaviour
{
       public GameObject gameOverScreen;
     public LogicScript logic;
    public bool birdIsAlive = false;
    // Start is called before the first frame update
    void Update()
    {
         if (Input.GetMouseButtonDown(0)== true && birdIsAlive == false )
        {
          gameOverScreen.SetActive(false);
          logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        
    }

  
}
