using UnityEngine;
using System.Collections;

public class TriggerLampadaire : CollisionHandler {

	private bool lesBailsDePol = true;

	protected override void PlayerCollisionEnter (GameObject player)
	{
		if(lesBailsDePol) {
			//GameManager.instance.player =  Joué l'animation du player
			GameManager.instance.LoadNextSceneAssyncTest();
			lesBailsDePol = false;
		}
	}

}
