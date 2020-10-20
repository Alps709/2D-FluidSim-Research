using UnityEngine;
using System.Collections;

public class ShipPlayerController : MonoBehaviour
{
	public float m_speed = 1f;
	public float m_movementSpeed = 1f;
    public Renderer m_moveArea;

	void Update()
	{
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-m_movementSpeed * Time.deltaTime, 0f, 0f));
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(m_movementSpeed * Time.deltaTime, 0f, 0f));
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0f, m_movementSpeed * Time.deltaTime, 0f));
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0f, -m_movementSpeed * Time.deltaTime, 0f));
		}
	
		//Check if within bounds of the renderer, if not move back in bounds on opposite side
		if (!m_moveArea.bounds.Contains(transform.position))
        {
            Vector3 new_pos = transform.position;
            if (transform.position.x > m_moveArea.bounds.max.x)
            {
                new_pos.x = m_moveArea.bounds.min.x;
            }
            else if (transform.position.x < m_moveArea.bounds.min.x)
            {
                new_pos.x = m_moveArea.bounds.max.x;
            }

            if (transform.position.y > m_moveArea.bounds.max.y)
            {
                new_pos.y = m_moveArea.bounds.min.y;
            }
            else if (transform.position.y < m_moveArea.bounds.min.y)
            {
                new_pos.y = m_moveArea.bounds.max.y;
            }

            transform.position = new_pos;
        }
	}
}