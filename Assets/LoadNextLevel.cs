using UnityEngine;
using System.Collections;

public class LoadNextLevel : CollisionHandler {

	private bool loadNextLevel = false;

	protected override void PlayerCollisionEnter (GameObject player)
	{
		if(loadNextLevel) {
			GameManager.instance.LoadNextLevel();
		}
	}
}
