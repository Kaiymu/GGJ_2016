using UnityEngine;
using System.Collections;

public class RemoveCollider : CollisionHandler {

	public GameObject beginCollider;

	protected override void PlayerCollisionEnter (GameObject player)
	{
		beginCollider.SetActive(true);
	}
}
