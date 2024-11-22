using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class enemyScript : MonoBehaviour
{
    public LogicScript logic;
    public int point = 0;
    public LogicScript bean;
    public bool beanIsAlive;
    private float movementSpeed = 10;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        beanIsAlive = true;
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
            logic.addScore(1);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.health -= 1;
            if (gameManager.health < 1)
            {
                logic.gameOver();
                beanIsAlive = false;
            }
        }
        if (collision.gameObject.CompareTag("Sensor"))
        {
            logic.reduceScore(1);
        }
    
    }
}
