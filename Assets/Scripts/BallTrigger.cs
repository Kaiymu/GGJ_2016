using UnityEngine;
using System.Collections;

public class BallTrigger : CollisionHandler {

	private bool isGo = true;

	protected override void BallCollisionEnter(GameObject ball) {
		if(isGo) {
			isGo = false;
			GameManager.instance.gameEvents = GAME_EVENTS.BALL;
			GameManager.instance.LoadNextSceneAssyncTest();
		}
	}
}
