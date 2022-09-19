using UnityEngine;

public class Movement : MonoBehaviour
{
    public float smooth = 5.0f;
    public float movementSpeed = 10f;
    public float rotationSpeed = 1f;

    public Vector3 originalPosition = Vector3.zero;
    
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, 0, zAxis);
        
        Move(direction);
        Rotate(xAxis * 180);

        if (Input.GetKey("space")) {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = originalPosition;
        }
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    public void Rotate(float direction)
    {
        transform.Rotate(Vector3.up, direction * rotationSpeed * Time.deltaTime);
    }
}
