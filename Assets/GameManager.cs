using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum GAME_EVENTS{NONE, BALL, COLLIDE, FIRST_LOVE, SMOKE, WEDDING, DEATHPARENT, SCHOOL};
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

	public Vector3[] posNiveaux;

	public GameObject currentCubeMaster;
	public GameObject previousCubeMaster;

	public GameObject[] scenesRoot = new GameObject[3];

	void Awake() {
		if(instance == null) {
			instance = this;
		} else {
			Destroy(this.gameObject);
		}

		InitializeArray();
	}

	private void InitializeArray() {
		posNiveaux = new Vector3[8];
		posNiveaux[0] = new Vector3(355.6f, -0.13f, 0f);
		posNiveaux[1] = new Vector3(506.03f, 6.83f, 0f);
		posNiveaux[2] = new Vector3(744.6f, 3.45f, 0f);
		posNiveaux[3] = new Vector3(1009.4f, 13.67f, 0f);
		posNiveaux[4] = new Vector3(1262.86f, 17.08f, 0f);
		posNiveaux[5] = new Vector3(1515.87f, 20.47f, 0f);
		posNiveaux[6] = new Vector3(1769.2f, 23.9f, 0f);
	}



	AsyncOperation ao;
	public IEnumerator LoadNextLevelAsync()
	{
		ao = SceneManager.LoadSceneAsync(currentLevel, LoadSceneMode.Additive);
		yield return ao;
	}

	public void LoadNextSceneAssyncTest() {
		doneLoadingScene = false;
		objectToTeleportPrevious = objectToTeleportNextScene;
		LoadNextLevel();
        HideCollider();
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
		Debug.Log(posNiveaux[currentLevel]);
		rootObject.transform.position = posNiveaux[currentLevel-1];
		beginCollider.SetActive(false);
	}  

    private void HideCollider()
    {
        beginCollider.SetActive(false);
        endCollider.SetActive(false);
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
