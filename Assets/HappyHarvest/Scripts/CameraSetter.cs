using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

namespace HappyHarvest
{
    [DefaultExecutionOrder(100)]
    public class CameraSetter : MonoBehaviour
    {
        private void Awake()
        {
            var cam = GetComponent<CinemachineCamera>();
            GameManager.Instance.MainCamera = cam;
        }
    }
}