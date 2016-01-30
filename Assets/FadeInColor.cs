using UnityEngine;
using System.Collections;

public class FadeInColor : MonoBehaviour {

	public Color color1;
	public Color color2;

	public float duration = 5.0f;

	private float _t;

	private Light _light;

	private void Awake() {
		_light = GetComponent<Light>();
	}

	void Update () {
		_light.color =	Color.Lerp(color1, color2, _t);

		if(_t < 1) {
			_t += Time.deltaTime / duration;
		}
	}
}
