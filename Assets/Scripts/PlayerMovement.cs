using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Vector2 dir;
	public float speed;

	public bool canClimbLadder;

	private bool m_FacingRight = true;

	public Rigidbody2D _rig;

	private void Awake() {
		_rig = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		
		dir.x = InputManager.instance.GoHorizontal() * speed * Time.deltaTime;

		if(InputManager.instance.GoVertical() != 0 && canClimbLadder) {
			_rig.gravityScale = 0;
		} else {
			_rig.gravityScale = 3;
		}

		if(canClimbLadder) {
			dir.y = InputManager.instance.GoVertical() * speed * Time.deltaTime;
		} else {
			dir.y = 0;
		}


		_rig.velocity = new Vector2(dir.x, _rig.velocity.y);

		if (dir.x > 0 && !m_FacingRight)
		{
			Flip();
		}
		else if (dir.x < 0 && m_FacingRight)
		{
			// ... flip the player.
			Flip();
		}
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
