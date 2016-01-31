using UnityEngine;
using System.Collections;

public class Cough : CollisionHandler {

    public AudioSource aud;
    public GameObject cig;

    protected override void PlayerCollisionEnter(GameObject player)
    {
        aud.Play();
        cig.SetActive(true);
    }

}
