using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBasedController : MonoBehaviour
{
    public AmmoniteAnimation ammoniteAnimation;
    public CloudAnimation cloudAnimation;
    public LampController lampAnimation;
    void Start()
    {
        StartCoroutine(BringOnTheAwe());
    }

    
    private IEnumerator BringOnTheAwe()
    {
        yield return new WaitForSeconds(3);
        ammoniteAnimation.StartAmmoniteAnimation();
        yield return new WaitForSeconds(10);
        cloudAnimation.StartCloudAnimation();
        yield return new WaitForSeconds(15);
        lampAnimation.StartLampAnimation();

        yield return null;
    }
}
