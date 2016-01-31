using UnityEngine;
using System.Collections;

public class alarmSchool : MonoBehaviour {

    private bool _first;
    private bool colli = false;
    private float _count = 0f;

	// Use this for initialization
	void Start () {
        _first = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (colli == true)
        {
            _count += Time.deltaTime;
            if (_count >= 20 && _first == false)
            {
                _first = true;
                this.gameObject.GetComponent<AudioSource>().Play();
                GameManager.instance.gameEvents = GAME_EVENTS.SCHOOL;
                GameManager.instance.LoadNextSceneAssyncTest();
            }
        }   
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            if (GameManager.instance.currentLevel == 5)
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
