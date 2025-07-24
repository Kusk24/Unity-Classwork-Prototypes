using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public Boolean isOnGround = true;

    void Start()
    {
        Physics.gravity *= gravityModifier;

        playerRb = GetComponent<Rigidbody>();
        // playerRb.AddForce(Vector3.up * 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
