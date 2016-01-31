using UnityEngine;
using System.Collections;

public class alarmSchool : MonoBehaviour {

    private bool _first;

	// Use this for initialization
	void Start () {
        _first = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Application.loadedLevel == 6)
            {
                if (Time.timeSinceLevelLoad == 20)
                {
                    if (_first == false)
                    {
                        this.gameObject.GetComponent<AudioSource>().Play();
                    }
                }
            }
            else if (_first == false)
            {
                _first = true;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
