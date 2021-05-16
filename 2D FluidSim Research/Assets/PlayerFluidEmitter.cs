using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FluidDynamics;
public class PlayerFluidEmitter : MonoBehaviour
{
   #region Variables

        public Main_Fluid_Simulation m_fluid;
        public Camera cam;

        public float m_velocityStrength = 100f;

        public float m_velocityRadius = 10f;

        public float m_particlesStrength = 50f;

        public float m_particlesRadius = 50f;

        public GameObject m_fireStartPos;

        private Collider m_tempCol;

        private Ray ray;
        private RaycastHit hitInfo;


        #endregion

        private void Start()
        {
            m_tempCol = m_fluid.GetComponent<Collider>();
        }

        public void ManipulateFluid(Vector2 direction)
        {
            if(direction == Vector2.zero)
            {
                direction = (m_fireStartPos.transform.position - gameObject.transform.position).normalized;
            }
            
            //Get position on screen of ray hit on texture
            Vector2 fireStartPos = (Vector2)m_fireStartPos.transform.position;
            Vector2 fireStartScreenSpace = new Vector2(cam.WorldToScreenPoint(fireStartPos).x, cam.WorldToScreenPoint(fireStartPos).y);

            //Get the ray to where the fire is being shot from
            ray = Camera.main.ScreenPointToRay(fireStartScreenSpace);
            //Debug.Log("Fire start pos: " + fireStartScreenSpace);
            //Debug.Log("Mouse pos: " + m_mousePos);
            if(m_tempCol.Raycast(ray, out hitInfo, 100))
            {
                direction.Normalize();
                Debug.Log("Direction: " + direction);
                //Add the dye/colour particles
                m_fluid.AddParticles(hitInfo.textureCoord, m_particlesRadius, m_particlesStrength);
                //Add velocity to this spot of the fluid sim
                m_fluid.AddVelocity(hitInfo.textureCoord, direction, m_velocityRadius);
            }
        }
}
