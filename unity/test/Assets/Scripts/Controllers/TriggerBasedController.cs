using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasedController : MonoBehaviour
{
    //public Collider ammoniteCollider;
    //public Collider cloudCollider;
    //public Collider lampCollider;
    public AmmoniteAnimation ammoniteAnimation;
    public CloudAnimation cloudAnimation;
    public LampController lampAnimation;
    private bool ammoniteTriggered = false;
    private bool cloudTriggered = false;
    private bool lampTriggered = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Interaction01"))
        {
            if (!ammoniteTriggered)
            {
                ammoniteAnimation.StartAmmoniteAnimation();
                ammoniteTriggered=true;
            }
            
        }

        if (other.CompareTag("Interaction02"))
        {
            if (cloudTriggered)
            {
                cloudAnimation.StartCloudAnimation();
                cloudTriggered=true;
            }
            
        }

        if (other.CompareTag("Interaction03"))
        {
            if (lampTriggered)
            {
                lampAnimation.StartLampAnimation();
                lampTriggered=true;
            }
                
        }
    }
}
