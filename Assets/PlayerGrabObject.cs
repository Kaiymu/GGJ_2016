using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerGrabObject : CollisionHandler {

	public GameObject grabbedObjectsContainer;

	private bool isGrabbedObject;
	private GameObject inventoryObject;

	protected override void GrabbedObjectCollisionEnter(GameObject objectGrabbed) {
		isGrabbedObject = true;
		inventoryObject = objectGrabbed;
	}

	protected override void GrabbedObjectCollisionExit(GameObject objectGrabbed) {
		isGrabbedObject = false;
		inventoryObject = null;
	}

	private void Update() {
		if(CrossPlatformInputManager.GetButtonDown("Fire1")) {
			DropObject();
			GrabbedObject();
		}
	}

	private void GrabbedObject() {
		if(isGrabbedObject) {
			inventoryObject.transform.parent = grabbedObjectsContainer.transform;
			inventoryObject.transform.position = grabbedObjectsContainer.transform.position;
			inventoryObject.transform.rotation = grabbedObjectsContainer.transform.rotation;
		}
	}

	public void DropObject() {
		if(grabbedObjectsContainer.transform.childCount != 0) {
			
			//grabbedObjectsContainer.transform.position = gameObject.transform.position;
			//inventoryObject.transform.parent = null;
			//grabbedObjectsContainer = null;
		}
	}
}
