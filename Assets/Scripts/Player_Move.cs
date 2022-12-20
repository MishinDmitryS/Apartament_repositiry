using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float Speed = 0.0f;
    public float JumpSpeed = 0.0f;
    public float Gravity = 0.0f;

    private Vector3 moveDirection;
    private CharacterController _char = null;

    private void Start()
    {
        _char = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (_char.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * Speed;
            moveDirection = transform.TransformDirection(moveDirection);
        }
        else
        {
            moveDirection.y -= Gravity * Time.deltaTime;
        }
        _char.Move(moveDirection * Time.deltaTime);
        teleport();
    }

    void teleport()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            _char.transform.position = new Vector3(2.163f, 0.98f, 2.67f);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            _char.transform.position = new Vector3(-0.849f, 0.98f, 2.389f);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            _char.transform.position = new Vector3(-1.6131f, 0.98f, -0.23f);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            _char.transform.position = new Vector3(1.191f, 0.98f, -0.073f);
        }
    }

}
