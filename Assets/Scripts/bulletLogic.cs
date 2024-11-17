using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    private float speed = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
