using UnityEngine;
using System.Collections;

public class ParallaxImpulse : MonoBehaviour {

	public GameObject player;
	public float speed;

	private PlatformerCharacter2D _velocityPlayer;
	void Start () {
		_velocityPlayer = player.GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 tempTrans;
	
		tempTrans = new Vector2(_velocityPlayer.velocityPlayer * speed, 0);
		transform.Translate(tempTrans);
	}
}
