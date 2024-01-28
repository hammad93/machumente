using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAnimation : MonoBehaviour
{
    public SkinnedMeshRenderer cloudRenderer;
    public float transitionTime;
    public float currentBlendWeight;
    public float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cloudRenderer.SetBlendShapeWeight(0, 0);
        StartCoroutine(AnimateCloud());
    }

    IEnumerator AnimateCloud()
    {
        yield return new WaitForSeconds(10f);
        
        while (time < transitionTime)
        {
            currentBlendWeight = cloudRenderer.GetBlendShapeWeight(0);
            currentBlendWeight += 100 / transitionTime * Time.deltaTime;
            cloudRenderer.SetBlendShapeWeight(0, currentBlendWeight);
            time += Time.deltaTime;
            yield return null;
        }
        
    }
}
