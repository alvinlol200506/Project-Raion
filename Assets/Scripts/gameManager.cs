using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class gameManager : MonoBehaviour
{
    public Transform enemySpawnPoint;
    float timer = 1;
    public enemyScript enemy;
    float currentTimer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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

    }


    
}
