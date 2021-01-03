using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FnOScripts : MonoBehaviour
{
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public LevelManager gameLevelManager;

    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);

        if (isTouchingGround)
        {
            Destroy(gameObject);
        }
    }
}
