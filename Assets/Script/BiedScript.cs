using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiedScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
     public bool birdIsAlive = true;
      public double deadZoneb = -15.99;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive )
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y < deadZoneb){
        logic.gameOver();
        birdIsAlive = false;
      }   
        
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
