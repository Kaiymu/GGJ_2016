using UnityEngine;
using System.Collections;

public class BallTrigger : CollisionHandler {

	protected override void BallCollisionEnter(GameObject ball) {
		GameManager.instance.gameEvents = GAME_EVENTS.BALL;
		GameManager.instance.endCollider.SetActive(false);
	}
}
