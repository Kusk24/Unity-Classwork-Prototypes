using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 0.25f;
    public float xRange = 10f;

    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch the projectile from the player
            Instantiate(projectilePrefab, new Vector3(transform.position.x, 0.8f, transform.position.z), projectilePrefab.transform.rotation);
        }
    }
}
