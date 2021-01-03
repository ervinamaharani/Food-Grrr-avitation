using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketScript : MonoBehaviour
{
    public float speed = 5f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    private LevelManager gameLevelManager;
    public int foodValue;
    public int objValue;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bomb")
        {
            gameLevelManager.ResetLevel();
        }
        else if (other.tag == "Food")
        {
            gameLevelManager.AddFood(foodValue);
            Destroy(other);
        }
        else if (other.tag == "Object")
        {
            gameLevelManager.AddObj(objValue);
            Destroy(other);
        }
 
    }

    
}
