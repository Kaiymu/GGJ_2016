using UnityEngine;
using System.Collections;

public class FirstSmoke : CollisionHandler {

    public GameObject animCig;
    private Animator _anim;

    protected override void PlayerCollisionEnter(GameObject player)
    {
        _anim = animCig.GetComponent<Animator>();
        _anim.SetBool("smoke", true);
    }

}
