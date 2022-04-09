using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 3f; 

    Vector3 crouch = new Vector3(1f, 0.5f, 1f);
    CharacterController playerController;
    PlayerGravity playerGravity;
    AudioSource audioSource; 

    void Start()
    {
        playerController = GetComponent<CharacterController>();
        playerGravity = GetComponent<PlayerGravity>();
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    { 
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 motion = transform.forward * verticalInput + transform.right * horizontalInput;

        if (Input.GetButtonDown("Jump") && playerGravity.checkGround)
        {
            playerGravity.velocity.y = Mathf.Sqrt(jumpHeight * -2f * playerGravity.gravity);
            audioSource.Play(); 
        }

        if (Input.GetButtonDown("Fire3"))
        {
            transform.localScale = crouch; 
        }
        else if (Input.GetButtonUp("Fire3"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }


        playerController.Move(motion * speed * Time.deltaTime);
    }
}
