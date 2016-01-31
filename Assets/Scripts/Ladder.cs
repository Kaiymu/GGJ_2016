using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Ladder : MonoBehaviour {

	private GameObject _player;

	private PlatformerCharacter2D _playerMovement;

	private void Start() {
		_playerMovement = GameManager.instance.player.GetComponent<PlatformerCharacter2D>();
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
