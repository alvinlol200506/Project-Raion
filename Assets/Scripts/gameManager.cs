using UnityEngine;

public class gameManager : MonoBehaviour
{
    public LogicScript logic;
    public GameObject heart1, heart2, heart3, heart4, heart5,heart6, heart7, heart8, heart9, heart10;
    public static int health;
    public Transform enemySpawnPoint;
    float timer = 1;

    public float timerDunia = 0;
    public enemyScript enemy;

    float currentTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        health = 5;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer = currentTimer + Time.deltaTime;
        if (currentTimer > timer) {
            Vector3 spawnPoint = new Vector3(Random.Range(-7.776745f, 7.776745f),enemySpawnPoint.position.y+1, enemySpawnPoint.position.z );
            Instantiate(enemy.gameObject, spawnPoint,Quaternion.Euler(0, 180, 0));
            currentTimer = 0;
        }


        timerDunia = timerDunia + Time.deltaTime;
        if (timerDunia > 5 && timerDunia < 10)
        {
            timer = 0.9f;
        }
        if (timerDunia > 10 && timerDunia < 15)
        {
            timer = 0.8f;
        }
        if (timerDunia > 15 && timerDunia < 20)
        {
            timer = 0.7f;
        }
        if (timerDunia > 20 && timerDunia < 25)
        {
            timer = 0.6f;
        }
        if (timerDunia > 25 && timerDunia < 30)
        {
            timer = 0.5f;
        }
        if (timerDunia > 30 && timerDunia < 35)
        {
            timer = 0.4f;
        }
        if (timerDunia > 35 && timerDunia < 40)
        {
            timer = 0.3f;
        }
        if (timerDunia > 40 && timerDunia < 45)
        {
            timer = 0.2f;
        }
        if (timerDunia > 45)
        {
            timer = 0.1f;
        }

        switch (health)
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                Time.timeScale = 0; // kalau gini playernya ndak bisa gerak
                break;
        }

    }


    
}
