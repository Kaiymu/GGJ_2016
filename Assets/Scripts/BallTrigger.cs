using UnityEngine;
using System.Collections;

public class BallTrigger : CollisionHandler {

	protected override void BallCollisionEnter(GameObject ball) {
		EventManager.instance.gameEvents = GAME_EVENTS.BALL;
	}
}
