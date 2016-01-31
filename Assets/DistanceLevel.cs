using UnityEngine;
using System.Collections;

public class DistanceLevel : MonoBehaviour {

	public GameObject distanceStart;
	public GameObject distanceEnd;

	public FadeInColor fadeInColor;
	public GameObject distancePlayer;

	private float maxDistance;

	void Start () {
		distancePlayer = GameManager.instance.player;
		fadeInColor = GameManager.instance.light.GetComponent<FadeInColor>();
		maxDistance = Vector2.Distance(GameManager.instance.beginCube.transform.position, GameManager.instance.endCube.transform.position);
	}

	void Update () {
		float distancePlayerEnd = Vector2.Distance(distancePlayer.transform.position, GameManager.instance.beginCube.transform.position);

		fadeInColor.playerProgression = (100 / maxDistance) * distancePlayerEnd;
	}
}
