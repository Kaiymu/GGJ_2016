using UnityEngine;
using System.Collections;

public class TriggerActivateFirstCollision : CollisionHandler {

	public GameObject firstCollisionToActivate;

	protected override void PlayerCollisionEnter (GameObject player)
	{
		firstCollisionToActivate.SetActive(true);	
	}
}
