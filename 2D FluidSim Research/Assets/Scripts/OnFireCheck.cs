using System;
using System.Collections;
using System.Collections.Generic;
using FluidDynamics;
using UnityEditor;
using UnityEngine;

public class OnFireCheck : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hitInfo;
    private Collider m_tempCol;
    private MeshRenderer m_tempRend;
    private int frameCount = 0;
    
    public Main_Fluid_Simulation m_fluid;
    public float damagePS = 25.0f;
    public SpriteRenderer playerColour;
    public bool IsOnFire = false;
    private PlayerHealth _playerHealth;

    private Vector2 playerPosScreenSpace;

    private void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        m_tempCol = m_fluid.GetComponent<Collider>();
        m_tempRend = m_fluid.m_tempRend as MeshRenderer;
    }

    //Update is called once per frame
    void Update()
    {
        frameCount++;

        if(frameCount > 10)
        {
            GetFluidPixelColour();
        }

        if(IsOnFire)
        {
            playerColour.color = Color.red;
            if(_playerHealth != null)
            {
                _playerHealth.Health -= damagePS * Time.deltaTime;
            }
        }
        else
        {
            playerColour.color = Color.white;
        }
    }

    void GetFluidPixelColour()
    {
        playerPosScreenSpace = new Vector2(Camera.main.WorldToScreenPoint(gameObject.transform.position).x,
            Camera.main.WorldToScreenPoint(gameObject.transform.position).y);

        //Get the ray to where the fire is being shot from
        ray = Camera.main.ScreenPointToRay(playerPosScreenSpace);

        if(m_tempCol.Raycast(ray, out hitInfo, 100))
        {
            //Vector2 textureCoord = new Vector2(hitInfo.textureCoord.x, hitInfo.textureCoord.y);
            //Texture2D tex = m_tempRend.material.GetTexture(0) as Texture2D;
            //Color color = (tex) ? tex.GetPixel((int)(textureCoord.x * tex.texelSize.x), (int)(textureCoord.y * tex.texelSize.y)) : Color.magenta;
            Color color = m_fluid.GetPixelColour(hitInfo.textureCoord.x, hitInfo.textureCoord.y);
            
            IsOnFire = (color.a > 0.9f);
            
            Debug.Log(IsOnFire);
        }
    }
}
