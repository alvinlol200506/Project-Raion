using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    private float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * 100 * Time.deltaTime;
    }
}
