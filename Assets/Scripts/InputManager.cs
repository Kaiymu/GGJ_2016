using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public static InputManager instance;
	
	void Awake() {
		if(instance == null) {
			instance = this;
		} else {
			Destroy(this.gameObject);
		}
	}

	public bool GoRight() {
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			return true;
		}
		return false;
	}

	public bool GoLeft() {
		if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			return true;
		}
		return false;
	}
}
