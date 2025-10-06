using System;
using System.Collections;
using System.Collections.Generic;
using HappyHarvest;
using UnityEngine;

namespace HappyHarvest
{
    public class CharacterAnimationEventHandler : MonoBehaviour
    {
        private PlayerController m_Controller;

        private void Awake()
        {
            m_Controller = GetComponentInParent<PlayerController>();
        }

        void LockControl()
        {
            m_Controller.ToggleControl(false);
        }

        void UnlockControl()
        {
            m_Controller.ToggleControl(true);
        }
    }
}
