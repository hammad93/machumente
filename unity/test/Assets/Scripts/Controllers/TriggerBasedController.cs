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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Interaction01"))
        {
            ammoniteAnimation.StartAmmoniteAnimation();
        }

        if (other.CompareTag("Interaction02"))
        {
            cloudAnimation.StartCloudAnimation();
        }

        if (other.CompareTag("Interaction03"))
        {
            lampAnimation.StartLampAnimation();
        }
    }
}
