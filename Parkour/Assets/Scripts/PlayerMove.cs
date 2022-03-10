using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 3f; 

    Vector3 crouch = new Vector3(1f, 0.5f, 1f); 

    // Update is called once per frame
    void Update()
    {
        CharacterController playerController = GetComponent<CharacterController>();
        float gravity = GetComponent<PlayerGravity>().gravity;
        bool checkGround = GetComponent<PlayerGravity>().checkGround; 

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 motion = transform.forward * verticalInput + transform.right * horizontalInput;

        if (Input.GetButtonDown("Jump") && checkGround)
        {
            GetComponent<PlayerGravity>().velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
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
