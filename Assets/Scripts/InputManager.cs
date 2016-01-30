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

	public int GoHorizontal() {
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			return 1;
		}

		if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			return -1;
		}

		return 0;
	}

	public int GoVertical() {
		if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			return 1;
		}
		return 0;
	}

}