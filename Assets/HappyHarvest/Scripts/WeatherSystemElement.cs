using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyHarvest
{
    [DefaultExecutionOrder(999)]
    [ExecuteInEditMode]
    public class WeatherSystemElement : MonoBehaviour
    {
        public WeatherSystem.WeatherType WeatherType;

        private void OnDestroy()
        {
            WeatherSystem.UnregisterElement(this);
        }
    }
}