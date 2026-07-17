using UnityEngine;

public class LogMoveSrip : MonoBehaviour
{
    public float moveSpeedLog;
    public float deadZone = -24;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeedLog * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
