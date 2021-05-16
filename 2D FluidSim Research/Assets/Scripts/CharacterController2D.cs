using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
	public class CharacterController2D : MonoBehaviour
	{
		[SerializeField] private float m_JumpForce = 400f;							// Amount of force added when the player jumps.
		[SerializeField] private float m_movementSpeed = 400.0f;
		[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
		[SerializeField] private bool m_AirControl = false;							// Whether or not a player can steer while jumping;
		[SerializeField] private LayerMask m_WhatIsGround;							// A mask determining what is ground to the character
		[SerializeField] private Transform m_GroundCheck;							// A position marking where to check if the player is grounded.

		const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
		bool m_Grounded;            // Whether or not the player is grounded.
		bool m_FacingRight = true;  // For determining which way the player is currently facing.
		Rigidbody2D m_Rigidbody2D;
		private PlayerFluidEmitter _fluidEmitter;
		Vector3 m_Velocity = Vector3.zero;

		public int extraJumps = 0;
		private int currentExtraJumps = 0;

		[Header("Events")]
		[Space]

		public UnityEvent OnLandEvent;

		[System.Serializable]
		public class BoolEvent : UnityEvent<bool> { }

		private void Awake()
		{
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
			_fluidEmitter = GetComponent<PlayerFluidEmitter>();

			if (OnLandEvent == null)
				OnLandEvent = new UnityEvent();
			
			//Init jump
			currentExtraJumps = extraJumps;
		}

		private void FixedUpdate()
		{
			bool wasGrounded = m_Grounded;
			m_Grounded = false;

			// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
			// This can be done using layers instead but Sample Assets will not overwrite your project settings.
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i].gameObject != gameObject)
				{
					m_Grounded = true;
					if (!wasGrounded)
					{
						OnLandEvent.Invoke();

						//Reset the extra jumps
						currentExtraJumps = extraJumps;
					}
				}
			}
		}
		
		public void Move(float move, bool crouch, bool jump)
		{
			//only control the player if grounded or airControl is turned on
			if (m_Grounded || m_AirControl)
			{
				// Move the character by finding the target velocity
				Vector3 targetVelocity = new Vector2(move * m_movementSpeed, m_Rigidbody2D.velocity.y);
				// And then smoothing it out and applying it to the character
				m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
				Debug.Log("Target Velocity: " + targetVelocity);

				// If the input is moving the player right and the player is facing left...
				if (move > 0 && !m_FacingRight)
				{
					// ... flip the player.
					Flip();
				}
				// Otherwise if the input is moving the player left and the player is facing right...
				else if (move < 0 && m_FacingRight)
				{
					// ... flip the player.
					Flip();
				}
			}
			// If the player should jump...
			if(jump && !m_Grounded && currentExtraJumps > 0)
			{
				//Cancel out downward velocity so each jump applies the same speed
				// if(m_Rigidbody2D.velocity.y)
				// {
					m_Rigidbody2D.velocity = new Vector2(m_Rigidbody2D.velocity.x, 0.0f);
				//}
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
				currentExtraJumps--;
			}
			else if (jump && m_Grounded)
			{
				m_Grounded = false;
				
				//Cancel out downward velocity so each jump applies the same speed
				if(m_Rigidbody2D.velocity.y < 0.0f)
				{
					m_Rigidbody2D.velocity = new Vector2(m_Rigidbody2D.velocity.x, 0.0f);
				}
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			}
		}

		public void Shoot(Vector2 direction)
		{
			_fluidEmitter.ManipulateFluid(direction);
		}
		
		private void Flip()
		{
			// Switch the way the player is labelled as facing.
			m_FacingRight = !m_FacingRight;

			// Multiply the player's x local scale by -1.
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
}