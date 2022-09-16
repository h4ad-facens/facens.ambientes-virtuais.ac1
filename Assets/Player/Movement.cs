using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10f;
    
    private void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xAxis, 0, zAxis);
        
        Move(direction);
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
