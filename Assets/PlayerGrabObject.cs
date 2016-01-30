using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerGrabObject : CollisionHandler {

	public GameObject grabbedObject;

	private bool _isGrabbedObject;
	private bool _objectInInventory = false;

	protected override void GrabbedObjectCollisionEnter(GameObject objectGrabbed) {
		_isGrabbedObject = true;
		grabbedObject = objectGrabbed;
	}

	protected override void GrabbedObjectCollisionExit(GameObject objectGrabbed) {
		if(!_objectInInventory) {
			_isGrabbedObject = false;
			grabbedObject = null;
		}
	}

	private void Update() {
		if(CrossPlatformInputManager.GetButtonDown("Fire1") && _isGrabbedObject) {
			if(_objectInInventory) {
				_objectInInventory = false;
			} else {
				_objectInInventory = true;
			}
				
			if(_objectInInventory) {
				GrabbedObject();
			} else {
				DropObject();
			}
		}
	}

	private void GrabbedObject() {
		if(_isGrabbedObject) {
			grabbedObject.transform.parent = gameObject.transform;
			grabbedObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y +2.5f);
			grabbedObject.transform.rotation = gameObject.transform.rotation;
		}
	}

	public void DropObject() {
		if(grabbedObject != null && _isGrabbedObject) {
			grabbedObject.transform.parent = null;
			grabbedObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
		}
	}
}
