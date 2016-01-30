using UnityEngine;
using System.Collections;

public enum GAME_EVENTS{NONE, BALL};
public class EventManager : MonoBehaviour {

	public static EventManager instance;

	public GAME_EVENTS gameEvents;

	void Awake() {
		if(instance == null) {
			instance = this;
		} else {
			Destroy(this.gameObject);
		}
	}
}
