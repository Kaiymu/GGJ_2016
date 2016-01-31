using UnityEngine;
using System.Collections;

public class cigSmash : CollisionHandler {

    public Animator Anim;

    protected override void CigCollisionEnter(GameObject player)
    {
        Anim.SetBool("Smoke", true);
        GameManager.instance.gameEvents = GAME_EVENTS.SMOKE;
        GameManager.instance.LoadNextSceneAssyncTest();
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
