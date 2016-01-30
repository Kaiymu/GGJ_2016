using UnityEngine;
using System.Collections;

public class FlipSprite : MonoBehaviour {

	public bool Flip(bool m_FacingRight)
	{
		m_FacingRight = !m_FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

		return m_FacingRight;
	}
}
