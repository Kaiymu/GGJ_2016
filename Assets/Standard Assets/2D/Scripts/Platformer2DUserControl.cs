using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
			m_Jump = CrossPlatformInputManager.GetButton("Jump");
        }


        private void FixedUpdate()
        {
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            m_Character.Move(h, m_Jump);
            m_Jump = false;
        }
    }
}
