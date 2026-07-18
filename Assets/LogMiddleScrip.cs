using UnityEngine;

public class LogMiddleScrip : MonoBehaviour
{
    public LogicScrip logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScrip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore();
        }
    }
}
