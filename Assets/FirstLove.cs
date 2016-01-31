using UnityEngine;
using System.Collections;

public class FirstLove : CollisionHandler {

    public Sprite spriteHouse;
    public SpriteRenderer house;

    protected override void GrabbedObjectCollisionEnter(GameObject grabbedObject)
    {
        house.sprite = spriteHouse;
        GameManager.instance.gameEvents = GAME_EVENTS.FIRST_LOVE;
        GameManager.instance.LoadNextSceneAssyncTest();
    }
}
