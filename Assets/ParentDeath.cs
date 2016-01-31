using UnityEngine;
using System.Collections;

public class ParentDeath : CollisionHandler {

    protected override void PlayerCollisionEnter(GameObject player)
    {
        GameManager.instance.gameEvents = GAME_EVENTS.DEATHPARENT;
        GameManager.instance.LoadNextSceneAssyncTest();
    }
}
