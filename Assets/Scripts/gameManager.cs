using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class gameManager : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int health;
    public Transform enemySpawnPoint;
    float timer = 1;
    public enemyScript enemy;
    float currentTimer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        Time.timeScale = 1; // bisa gerak
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer = currentTimer + Time.deltaTime;
        if (currentTimer > timer) {
            Vector3 spawnPoint = new Vector3(Random.Range(-7.776745f, 7.776745f),enemySpawnPoint.position.y, enemySpawnPoint.position.z );
            Instantiate(enemy.gameObject, spawnPoint,Quaternion.identity);
            currentTimer = 0;
        }

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                Time.timeScale = 0; // kalau gini playernya ndak bisa gerak
                break;
        }

    }


    
}
