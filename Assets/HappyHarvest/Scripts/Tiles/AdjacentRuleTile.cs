using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace HappyHarvest
{
    [CreateAssetMenu]
    public class AdjacentRuleTile : RuleTile<AdjacentRuleTile.Neighbor>
    {
        public class Neighbor : RuleTile.TilingRule.Neighbor
        {
            public const int Adjacent = 3;
        }

        public TileBase[] AdjacentTiles;

        public override bool RuleMatch(int neighbor, TileBase other)
        {

            switch (neighbor)
            {
                case Neighbor.Adjacent:
                    return AdjacentTiles.Contains(other);
            }

            return base.RuleMatch(neighbor, other);
        }
    }
}