using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class  PlayerControlManager : MonoBehaviour
{

    public CharacterController2D Character;
    private PlayerControls Controls;
    
    private float _horizontalMove = 0.0f;
    private bool jump = false;
    private bool canActivate = false;
    

    // Start is called before the first frame update
    void Awake()
    {
        Controls = new PlayerControls();

        Controls.Gameplay.Jump.performed += context =>
        {
            Jump();
            canActivate = false;
        };

        Controls.Gameplay.HorizontalMovement.performed += context =>
        {
            _horizontalMove = context.ReadValue<float>();
        };
        
        Controls.Gameplay.HorizontalMovement.canceled += context =>
        {
            _horizontalMove = 0.0f;
        };
    }

    private void OnEnable()
    {
        Controls.Gameplay.Enable();
    }

    void FixedUpdate()
    {
        Debug.Log(_horizontalMove);
        //Move the character based on input
        Character.Move(_horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        canActivate = true;
    }

    void Jump()
    {
        jump = true;
    }
}
