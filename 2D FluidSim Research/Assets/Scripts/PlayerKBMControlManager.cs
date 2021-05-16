using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class  PlayerKBMControlManager : MonoBehaviour
{

    public CharacterKBMController2D Character;
    private PlayerControls Controls;
    
    private float _horizontalMove = 0.0f;
    private bool jump = false;
    private float shoot;
    private Vector2 shootDirection;

    // Start is called before the first frame update
    void Awake()
    {
        Controls = new PlayerControls();

        Controls.PlayerKeyboard.Jump.performed += context =>
        {
            Jump();
        };

        Controls.PlayerKeyboard.HorizontalMovement.performed += context =>
        {
            _horizontalMove = context.ReadValue<float>();
        };
        
        Controls.PlayerKeyboard.HorizontalMovement.canceled += context =>
        {
            _horizontalMove = 0.0f;
        };

        Controls.PlayerKeyboard.Shoot.performed += context =>
        {
            shoot = context.ReadValue<float>();
        };
        
        Controls.PlayerKeyboard.Shoot.canceled += context =>
        {
            shoot = context.ReadValue<float>();
        };
    }

    private void OnEnable()
    {
        Controls.PlayerKeyboard.Enable();
    }

    void FixedUpdate()
    {
        //Move the character based on input
        Character.Move(_horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

        if(shoot >= 0.8f)
        {
            Character.Shoot();
        }
    }

    void Jump()
    {
        jump = true;
    }
}