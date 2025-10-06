using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyHarvest
{
    public class Loader : MonoBehaviour
    {
        public int TargetScene = 3;
        
        private void Start()
        {
            SceneManager.LoadScene(TargetScene);
        }
    }
}
