using UnityEngine;

public class beanScript : MonoBehaviour
{
    public GameObject bullet;
    private float movementSpeed = 8;
    public enemyScript enemy;

    private Rigidbody rb;
    public float jumpForce = 0.5f;
    public CapsuleCollider col;
    public LayerMask groundLayer;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<enemyScript>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float maxDistance = 7.776745f;
        float inputMovementX = Input.GetAxisRaw("Horizontal");
        Vector3 movementDirection = new Vector3(inputMovementX, 0, 0);
        Vector3 directionOutput = transform.position + (movementDirection * movementSpeed * Time.deltaTime);

        transform.position += movementDirection * movementSpeed * Time.deltaTime;
        directionOutput.x = Mathf.Clamp(directionOutput.x, -maxDistance, maxDistance);
        transform.position = directionOutput;

        if (Input.GetMouseButtonDown(0) && enemy.beanIsAlive)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(newBullet, 3);
        }
        if (Input.GetKeyDown(KeyCode.Space) && enemy.beanIsAlive && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, 
            col.bounds.min.y, col.bounds.center.z), col.radius * 0.9f, groundLayer);
    }
}
