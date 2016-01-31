using UnityEngine;
using System.Collections;

public class DistanceLevel : MonoBehaviour {

	public GameObject distanceStart;
	public GameObject distanceEnd;

	public FadeInColor fadeInColor;
		
	public GameObject distancePlayer;

	private float maxDistance;

	void Start () {
		maxDistance = Vector2.Distance(distanceStart.transform.position, distanceEnd.transform.position);
	}

	void Update () {
		float distancePlayerEnd = Vector2.Distance(distancePlayer.transform.position, distanceStart.transform.position);

		fadeInColor.playerProgression = (100 / maxDistance) * distancePlayerEnd;
	}
}
