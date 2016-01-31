using UnityEngine;
using System.Collections;

public class PassingValues : MonoBehaviour {

	public GAME_EVENTS victoryCondition;
	public GameObject rootObject;
	public GameObject objectToTeleportNextScene;
	public GameObject beginCube;
	public GameObject endCube;

	public GameObject beginCollision;
	public GameObject endCollision;

	public GameObject currentCubeMaster;

	private void Awake() {
		GameManager.instance.rootObject = rootObject;
		GameManager.instance.objectToTeleportNextScene = objectToTeleportNextScene;
		GameManager.instance.beginCube = beginCube;
		GameManager.instance.endCube = endCube;
		GameManager.instance.victoryCondition = victoryCondition;

		GameManager.instance.beginCollider = beginCollision;
        GameManager.instance.endCollider = endCollision;

        GameManager.instance.currentCubeMaster = currentCubeMaster;
	}
}
