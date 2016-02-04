using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    public bool IsLighting = false;
    [SerializeField]
    private Animator _anim;
    [SerializeField]
    private PlatformerCharacter2D _charaController;
    [SerializeField]
    private SpriteRenderer _sprLamp;
    [SerializeField]
    private Sprite _lampOn;
    [SerializeField]
    private AudioSource _aud;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col);
        if (col.tag == "Finish")
        {
            _anim.SetBool("Lighting", true);
            _anim.SetBool("IsLighting", true);
            StartLighting();
            Destroy(col.gameObject);
        }   
    }

    void StartLighting()
    {
        _charaController.m_MaxSpeed = 0;
        _charaController.velocityPlayer = 0f;
    }

    void StopLighting()
    {
        _anim.SetBool("Lighting", false);
        _anim.SetBool("IsLighting", false);
        _charaController.m_MaxSpeed = 3;
    }

    void LightLamp()
    {
        _sprLamp.sprite = _lampOn;
        _aud.Play();
    }
}
