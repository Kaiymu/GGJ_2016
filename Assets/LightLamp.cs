using UnityEngine;
using System.Collections;

public class LightLamp : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer _sprLamp;
    [SerializeField]
    private Sprite _lampOn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        _sprLamp.sprite = _lampOn;
    }
}
