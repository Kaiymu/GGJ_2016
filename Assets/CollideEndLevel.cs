using UnityEngine;
using System.Collections;

public class CollideEndLevel : CollisionHandler {

	public GameObject colliderEndLevel;

	protected override void PlayerCollisionEnter (GameObject player)
	{
		colliderEndLevel.SetActive(false);
		GameManager.instance.gameEvents = GAME_EVENTS.COLLIDE;
	}
}
