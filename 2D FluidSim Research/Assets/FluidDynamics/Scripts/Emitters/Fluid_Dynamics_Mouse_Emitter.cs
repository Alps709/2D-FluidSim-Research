using UnityEngine;
namespace FluidDynamics
{
    [AddComponentMenu("Fluid Dynamics/Emitters/Fluid Mouse Emitter")]
    public class Fluid_Dynamics_Mouse_Emitter : MonoBehaviour
    {
        #region Variables
        public Main_Fluid_Simulation m_fluid;
        public Camera cam;
        public states updateMode;
        public bool m_alwaysOn = false;

        public float m_velocityStrength = 10f;

        public float m_velocityRadius = 10f;

        public float m_particlesStrength = 10f;

        public float m_particlesRadius = 10f;

        public GameObject m_player;
        
        private Collider m_tempCol;
        private Renderer m_tempRend;
        
        private Ray ray;
        private RaycastHit hitInfo;
        private Vector2 direction;
        private Vector2 m_mousePos;
        
        
        #endregion
        private void Start()
        {
            m_tempCol = m_fluid.GetComponent<Collider>();
            m_tempRend = m_fluid.GetComponent<Renderer>();
        }
        private void DrawGizmo()
        {
            float col = m_particlesStrength / 10000.0f;
            Gizmos.color = Color.Lerp(Color.yellow, Color.red, col);
            Gizmos.DrawWireSphere(transform.position, m_particlesRadius);
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, m_velocityRadius);
        }
        private void OnDrawGizmosSelected()
        {
            DrawGizmo();
        }
        private void OnDrawGizmos()
        {
            DrawGizmo();
        }
        private void Update()
        {
            if (updateMode == states.Update)
                ManipulateParticles();
        }
        private void LateUpdate()
        {
            if (updateMode == states.LateUpdate)
                ManipulateParticles();
        }
        private void FixedUpdate()
        {
            if (updateMode == states.FixedUpdate)
                ManipulateParticles();
        }
        private void ManipulateParticles()
        {
            // if (Input.GetMouseButton(0) || m_alwaysOn)
            // {
            //     m_mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
            //     ray = Camera.main.ScreenPointToRay(m_mousePos);
            //     if (m_tempCol.Raycast(ray, out hitInfo, 100))
            //     {
            //         fWidth = m_tempRend.bounds.extents.x * 2f;
            //         fRadius = (m_particlesRadius * m_fluid.GetParticlesWidth()) / fWidth;
            //         m_fluid.AddParticles(hitInfo.textureCoord, fRadius, m_particlesStrength * Time.deltaTime);
            //     }
            // }
            if (Input.GetMouseButton(0) || m_alwaysOn)
            {
                //Get position on screen of ray hit on texture
                float tempX = m_player.transform.position.x;
                float tempY = m_player.transform.position.y;
                Vector3 fireStartPos = new Vector3(tempX, tempY, 0f);
                Vector3 fireStartScreenSpace = cam.WorldToScreenPoint(fireStartPos);
                
                //Get mouse pos to shoot fire towards
                m_mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
                
                //Get the ray to where the fire is being shot from
                ray = Camera.main.ScreenPointToRay(fireStartScreenSpace);
                
                Debug.Log("Fire start pos: " + fireStartScreenSpace);
                Debug.Log("Mouse pos: " + m_mousePos);
                
                if (m_tempCol.Raycast(ray, out hitInfo, 100))
                {
                    Vector2 firestart = new Vector2(fireStartScreenSpace.x, fireStartScreenSpace.y);
                    direction = m_mousePos - firestart;
                    direction.Normalize();
                    direction *= m_velocityStrength;
                    Debug.Log("Velocity strength: " + m_velocityStrength);
                    Debug.Log("Delta time: " + Time.deltaTime);
                    Debug.Log("Direction: " + direction);
                    Debug.Log("Direction: " + direction);
                    
                    m_fluid.AddParticles(hitInfo.textureCoord, 100f, 1000f);
                    m_fluid.AddVelocity(hitInfo.textureCoord, direction * m_velocityStrength, m_velocityRadius);
                }
            }

            if (Input.GetMouseButton(1) || m_alwaysOn)
            {
                //Get position on screen of ray hit on texture
                float tempX = m_player.transform.position.x;
                float tempY = m_player.transform.position.y;
                Vector3 fireStartPos = new Vector3(tempX, tempY, 0f);
                Vector3 fireStartScreenSpace = cam.WorldToScreenPoint(fireStartPos);
                
                //Get mouse pos to shoot fire towards
                m_mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                
                //Get the ray to where the fire is being shot from
                ray = Camera.main.ScreenPointToRay(fireStartScreenSpace);
                
                Debug.Log("Fire start pos: " + fireStartScreenSpace);
                Debug.Log("Mouse pos: " + m_mousePos);
                
                if (m_tempCol.Raycast(ray, out hitInfo, 100))
                {
                    Vector2 firestart = new Vector2(fireStartScreenSpace.x, fireStartScreenSpace.y);
                    direction = m_mousePos - firestart;
                    direction.Normalize(); 
                    direction *= m_velocityStrength;

                    m_fluid.AddVelocity(hitInfo.textureCoord, direction * m_velocityStrength, m_velocityRadius);
                }
            }
        }
    }
}