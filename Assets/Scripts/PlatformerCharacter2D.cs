using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlatformerCharacter2D : MonoBehaviour
{
    [SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
    [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
    [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
    [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character


	public bool canClimbLadder;
	public FlipSprite flipSprite;
	[HideInInspector]
	public float velocityPlayer;
    private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
    const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    private bool m_Grounded;            // Whether or not the player is grounded.
    private Transform m_CeilingCheck;   // A position marking where to check for ceilings
    const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
    public Animator m_Anim;            // Reference to the player's animator component.
    private Rigidbody2D m_Rigidbody2D;
    private bool m_FacingRight = true;  // For determining which way the player is currently facing.


    private void Awake()
    {
        m_GroundCheck = transform.Find("GroundCheck");
        m_CeilingCheck = transform.Find("CeilingCheck");
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
		flipSprite = gameObject.GetComponentInChildren<FlipSprite>();
    }
		
    private void FixedUpdate()
    {
        m_Grounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                m_Grounded = true;
        }
			
		m_Anim.SetBool("Ground", m_Grounded);
    }
		
    public void Move(float move, bool jump)
    {
        // The Speed animator parameter is set to the absolute value of the horizontal input.
        m_Anim.SetFloat("Speed", Mathf.Abs(move));

		float temptVelocityY;

		if(canClimbLadder) {
			m_Rigidbody2D.gravityScale = 0;
			temptVelocityY = CrossPlatformInputManager.GetAxis("Jump") * m_JumpForce;
			m_Grounded = false;
		} else {
			m_Rigidbody2D.gravityScale = 3;
			temptVelocityY = m_Rigidbody2D.velocity.y;
			//m_Grounded = true;
		}
				
		m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, temptVelocityY);

		velocityPlayer = move;
        if (move > 0 && !m_FacingRight)
        {
			m_FacingRight = flipSprite.Flip(m_FacingRight);
        }
        else if (move < 0 && m_FacingRight)
        {
			m_FacingRight = flipSprite.Flip(m_FacingRight);
        }
    }
}
