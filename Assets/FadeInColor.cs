using UnityEngine;
using System.Collections;

public class FadeInColor : MonoBehaviour {

	public Color color1;
	public Color color2;

	public float duration = 5.0f;
	[HideInInspector]
	public float playerProgression = 0;

	private float _t;

	private Light _light;

	private void Awake() {
		_light = GetComponent<Light>();
	}

	void Update () {
		_light.color =	Color.Lerp(color1, color2, playerProgression / 100);

		if(_t < 1) {
			_t += Time.deltaTime / duration;
		}
	}

}
