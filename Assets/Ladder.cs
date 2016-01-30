using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Ladder : MonoBehaviour {

	public GameObject player;

	private PlatformerCharacter2D _playerMovement;

	private void Awake() {
		_playerMovement = player.GetComponent<PlatformerCharacter2D>();
	}

	private void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			_playerMovement.canClimbLadder = true;
		}
	}

	private void OnTriggerExit2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			_playerMovement.canClimbLadder = false;
		}
	}
}
