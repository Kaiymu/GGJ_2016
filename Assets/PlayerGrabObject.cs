using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerGrabObject : CollisionHandler {

	public GameObject grabbedObject;

	private bool isGrabbedObject;

	protected override void GrabbedObjectCollisionEnter(GameObject objectGrabbed) {
		isGrabbedObject = true;
		grabbedObject = objectGrabbed;
	}

	protected override void GrabbedObjectCollisionExit(GameObject objectGrabbed) {
		isGrabbedObject = false;
		grabbedObject = null;
	}

	private void Update() {
		if(CrossPlatformInputManager.GetButtonDown("Fire1")) {
			//DropObject();
			GrabbedObject();
		}
	}

	private void GrabbedObject() {
		if(isGrabbedObject) {

			grabbedObject.transform.parent = gameObject.transform;
			Debug.Log(grabbedObject.transform.localScale.y);
			grabbedObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y +2.5f);
			grabbedObject.transform.rotation = gameObject.transform.rotation;
			//grabbedObject.transform.parent = gameObject.transform;
		}
	}

	public void DropObject() {
		grabbedObject.transform.parent = null;
		grabbedObject = null;
	}
}
