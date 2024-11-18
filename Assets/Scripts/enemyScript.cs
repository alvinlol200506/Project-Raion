using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class enemyScript : MonoBehaviour
{
    public LogicScript logic;
    public int point = 0;
    public LogicScript bean;
    public bool beanIsAlive = true;
    private float movementSpeed = 10;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movementDirection = new Vector3(0, 0, -1);
        transform.position += movementDirection * movementSpeed * Time.deltaTime;

        Destroy(gameObject, 3.5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            logic.gameOver();
            beanIsAlive = false;
        }
    
    }
}
