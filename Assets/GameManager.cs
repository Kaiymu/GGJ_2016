using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum GAME_EVENTS{NONE, BALL, COLLIDE};
public class GameManager : MonoBehaviour {

	public GAME_EVENTS gameEvents;
	public GAME_EVENTS victoryCondition;
	public static GameManager instance;

	public int currentLevel = 0;

	public GameObject test;
	public GameObject rootObject;
	public GameObject objectToTeleportNextScene;
	public GameObject objectToTeleportPrevious;
	public GameObject player;
	public GameObject light;
	public GameObject beginCube;
	public GameObject endCube;
	public GameObject beginCollider;
	public GameObject endCollider;

	public GameObject currentCubeMaster;
	public GameObject previousCubeMaster;

	public GameObject[] scenesRoot = new GameObject[3];

	void Awake() {
		if(instance == null) {
			instance = this;
		} else {
			Destroy(this.gameObject);
		}
	}

	private void Start() {
		LoadNextLevel();
		//StartCoroutine(LoadNextLevelAsync());
	}

	AsyncOperation ao;
	public IEnumerator LoadNextLevelAsync()
	{
		ao = SceneManager.LoadSceneAsync(currentLevel, LoadSceneMode.Additive);
		yield return ao;
	}

	public void LoadNextSceneAssyncTest() {
		objectToTeleportPrevious = objectToTeleportNextScene;
		StartCoroutine(LoadNextLevelAsync());
	}

	public void LoadNextLevel() {
		currentLevel++;
	}
		

	public void SetCubes(GameObject cubeBegin, GameObject cubeEnd) {
		beginCube = cubeBegin;
		endCube = cubeEnd;
	}

	public void TeleportNextScene() {
		rootObject.transform.position = objectToTeleportPrevious.transform.position;

		beginCollider.SetActive(false);
	}  

	public void CubeMasterLight() {
		//currentCubeMaster.GetComponent<DistanceLevel>().distanceStart = 
	}

	bool doneLoadingScene = false;
   	public void Update() {
		if(ao != null && !doneLoadingScene)
		{
			if(ao.isDone)
			{
				doneLoadingScene = true;
				TeleportNextScene();
			}
		}

		if(gameEvents == victoryCondition) {
			Debug.Log("win");
			// Joué l'animation du lampadaire enflammée
			// Désactivée la collision de fin de niveau.
			// 
			// Débloqué le lampadaire, virée la collision de fin de niveau et load le level.
		}
	}
}
