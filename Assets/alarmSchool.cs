using UnityEngine;
using System.Collections;

public class alarmSchool : MonoBehaviour {

    private bool _first;
    private bool colli = false;

	// Use this for initialization
	void Start () {
        _first = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (colli == true)
        {
            //Balance alarme 10 secondes plus tard
        }   
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            if (Application.loadedLevel == 6)
            {
                colli = true;
                    //fin du code dans Update
            }
            else if (_first == false)
            {
                _first = true;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
