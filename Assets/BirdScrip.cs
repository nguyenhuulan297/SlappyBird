using UnityEngine;

public class BirdScrip : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float slapStrength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            birdRigidbody.linearVelocity = Vector2.up * slapStrength;
        }
        
    }
}
