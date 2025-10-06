using UnityEngine;
using UnityEngine.VFX;

namespace HappyHarvest
{
    public class ToolAnimationEventHandler : MonoBehaviour
    {
        [Header("Front")]
        public VisualEffect FrontEffect;
        public string FrontEffectId;
    
        [Header("Up")]
        public VisualEffect UpEffect;
        public string UpEffectId;
    
        [Header("Side")]
        public VisualEffect SideEffect;
        public string SideEffectId;

        public void TriggerFrontVFX()
        {
            SideEffect.gameObject.SetActive(false);
            UpEffect.gameObject.SetActive(false);
            FrontEffect.gameObject.SetActive(true);
        
            FrontEffect.SendEvent(FrontEffectId);
        }
    
        public void TriggerSideVFX()
        {
            SideEffect.gameObject.SetActive(true);
            UpEffect.gameObject.SetActive(false);
            FrontEffect.gameObject.SetActive(false);
        
            SideEffect.SendEvent(SideEffectId);
        }
    
        public void TriggerUpVFX()
        {
            SideEffect.gameObject.SetActive(false);
            UpEffect.gameObject.SetActive(true);
            FrontEffect.gameObject.SetActive(false);
        
            UpEffect.SendEvent(UpEffectId);
        }
    }
}