using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class  PlayerGamepadControlManager : MonoBehaviour
{

    public CharacterGamepadController2D Character;
    private PlayerControls Controls;
    
    private float _horizontalMove = 0.0f;
    private bool jump = false;
    private float shoot;
    private Vector2 shootDirection;

    // Start is called before the first frame update
    void Awake()
    {
        Controls = new PlayerControls();

        Controls.PlayerGamepad.Jump.performed += context =>
        {
            Jump();
        };

        Controls.PlayerGamepad.HorizontalMovement.performed += context =>
        {
            _horizontalMove = context.ReadValue<float>();
        };
        
        Controls.PlayerGamepad.HorizontalMovement.canceled += context =>
        {
            _horizontalMove = 0.0f;
        };

        Controls.PlayerGamepad.Shoot.performed += context =>
        {
            shoot = context.ReadValue<float>();
        };
        
        Controls.PlayerGamepad.Shoot.canceled += context =>
        {
            shoot = context.ReadValue<float>();
        };
        
        Controls.PlayerGamepad.Aim.performed += context =>
        {
            shootDirection = context.ReadValue<Vector2>();
        };
        
        Controls.PlayerGamepad.Aim.canceled += context =>
        {
            shootDirection = new Vector2(0.0f, 0.0f);
        };
    }

    private void OnEnable()
    {
        Controls.PlayerGamepad.Enable();
    }

    void FixedUpdate()
    {
        //Move the character based on input
        Character.Move(_horizontalMove * Time.fixedDeltaTime, shootDirection, jump);
        jump = false;

        if(shoot >= 0.8f)
        {
            Character.Shoot(shootDirection);
        }
    }

    void Jump()
    {
        jump = true;
    }
}
