using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelDinamycly : MonoBehaviour {

	public void Start() {
		LevelToLoad(1);
	}
	public void LevelToLoad(int index) {
		SceneManager.LoadScene(index);
	}
}
