using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private float movementSpeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movementDirection = new Vector3(0, 0, -1);
        transform.position += movementDirection * movementSpeed * Time.deltaTime;
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
            Destroy(collision.gameObject);
        }
    }

}
