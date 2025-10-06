using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace HappyHarvest
{
    [RequireComponent(typeof(Tilemap))]
    public class WalkableSurface : MonoBehaviour
    {
        private void Awake()
        {
            GameManager.Instance.WalkSurfaceTilemap = GetComponent<Tilemap>();
        }
    }
}
