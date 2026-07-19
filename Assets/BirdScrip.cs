using System;
using UnityEngine;

public class BirdScrip : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float slapStrength;
    public LogicScrip logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScrip>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.currentState != LogicScrip.GameState.Playing) return;

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidbody.linearVelocity = Vector2.up * slapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
