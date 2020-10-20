using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Character;

    public float RunSpeed = 40.0f;
    private float _horizontalMove = 0.0f;
    private bool jump = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        _horizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
    }

    void FixedUpdate()
    {
        Character.Move(_horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
