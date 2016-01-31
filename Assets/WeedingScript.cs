using UnityEngine;
using System.Collections;

public class WeedingScript : CollisionHandler {

    protected override void GrabbedObjectCollisionEnter(GameObject grabbedObject)
    {
        GameManager.instance.gameEvents = GAME_EVENTS.WEDDING;
        GameManager.instance.LoadNextSceneAssyncTest();
    }
}
