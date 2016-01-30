using UnityEngine;
using System.Collections;

public abstract class CollisionHandler : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			PlayerCollisionEnter(col.gameObject);
		}
		if(col.gameObject.tag == "GrabbedObject") {
			GrabbedObjectCollisionEnter(col.gameObject);
		}

		if(col.gameObject.tag == "Ball") {
			BallCollisionEnter(col.gameObject);
		}
	}

	private void OnTriggerExit2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			PlayerCollisionExit(col.gameObject);
		}
		if(col.gameObject.tag == "GrabbedObject") {
			GrabbedObjectCollisionExit(col.gameObject);
		}
	}

	protected virtual void PlayerCollisionEnter(GameObject player) {
	}

	protected virtual void GrabbedObjectCollisionEnter(GameObject grabbedObject) {
	}

	protected virtual void BallCollisionEnter(GameObject player) {
	}


	protected virtual void PlayerCollisionExit(GameObject player) {
	}

	protected virtual void GrabbedObjectCollisionExit(GameObject grabbedObject) {
	}
}
