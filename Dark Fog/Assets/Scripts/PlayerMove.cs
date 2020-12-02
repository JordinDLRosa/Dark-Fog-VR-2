using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public string horizontalInput;
    public string verticalInput;
    public float movementSpeed;
    public GameObject Enemy;
    public Camera PlayerCamera;
    

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        
    }

    private void Update()
    {
        PlayerMovement();

      /*   bool detection()
        {
        return Physics.Raycast(transform.position., PlayerCamera, 10, gameObject.layer = 9);
        }
        if (detection())
        {
            
            Destroy(Enemy);
        }*/

    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInput) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInput) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }
}
