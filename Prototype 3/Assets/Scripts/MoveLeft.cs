using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private PlayerController playerControllerScripts;

    private float leftBound = -15;
    void Start()
    {
        playerControllerScripts = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScripts.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
