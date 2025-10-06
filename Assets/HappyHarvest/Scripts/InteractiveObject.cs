using UnityEngine;


namespace HappyHarvest
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        public abstract void InteractedWith();

        protected void Awake()
        {
            gameObject.layer = 31;
        }
    }
}