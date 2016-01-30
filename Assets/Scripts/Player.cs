using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour {

	public Vector2 speed;

	void Update () {
		if(InputManager.instance.GoRight()) {
			if(speed.x < 0) {
				speed.x *= -1;
			}
			transform.Translate(speed);
		}
		if(InputManager.instance.GoLeft()) {
			
			transform.Translate(-speed);
		}
	}
}
