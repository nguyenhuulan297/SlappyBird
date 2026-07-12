using UnityEngine;

public class LogMoveSrip : MonoBehaviour
{
    public float moveSpeedLog;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeedLog);
    }
}
