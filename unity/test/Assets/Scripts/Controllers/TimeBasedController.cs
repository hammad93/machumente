using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBasedController : MonoBehaviour
{
    public AmmoniteAnimation ammoniteAnimation;
    public CloudAnimation cloudAnimation;
    public TreeController treeController;
    public LampController lampAnimation;
    public WindowController windowController;
    void Start()
    {
        StartCoroutine(BringOnTheAwe());
    }

    
    private IEnumerator BringOnTheAwe()
    {
        yield return new WaitForSeconds(15);
        ammoniteAnimation.StartAmmoniteAnimation();
        yield return new WaitForSeconds(15);
        cloudAnimation.StartCloudAnimation();
        yield return new WaitForSeconds(15);
        treeController.StartTreeTalk();
        yield return new WaitForSeconds(15);
        lampAnimation.StartLampAnimation();
        yield return new WaitForSeconds(20);
        windowController.StartWindowAction();

        yield return null;
    }
}
