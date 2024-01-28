using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;

public class TreeController : MonoBehaviour
{
    public GameObject tree01;
    public GameObject tree02;
    private float time;
    private SkinnedMeshRenderer tree01Renderer;
    private SkinnedMeshRenderer tree02Renderer;
    private float blendWeightTree01_01;
    private float blendWeightTree01_02;
    private float blendWeightTree02_01;
    private float blendWeightTree02_02;
    public float transitionTimeMorph;
    public float transitionTimeOpen;
    public float transitionTimeClose;
    
    // Start is called before the first frame update
    void Awake()
    {
        tree01Renderer = tree01.GetComponent<SkinnedMeshRenderer>();
        tree02Renderer = tree02.GetComponent<SkinnedMeshRenderer>();
        tree01Renderer.SetBlendShapeWeight(0,0);
        tree01Renderer.SetBlendShapeWeight(1, 0);
        tree02Renderer.SetBlendShapeWeight(0, 0);
        tree02Renderer.SetBlendShapeWeight(1, 0);
    }

    public void StartTreeTalk()
    {
        StartCoroutine(TreeTalk());
    }

    public IEnumerator TreeTalk()
    {

        //blend to face
        while(time < transitionTimeMorph)
        {
            blendWeightTree01_01 = tree01Renderer.GetBlendShapeWeight(1);
            blendWeightTree02_01 = tree02Renderer.GetBlendShapeWeight(1);
            blendWeightTree01_01 += 50 / transitionTimeMorph * Time.deltaTime;
            blendWeightTree02_01 = blendWeightTree01_01;
            tree01Renderer.SetBlendShapeWeight(1, blendWeightTree01_01);
            tree02Renderer.SetBlendShapeWeight(1, blendWeightTree02_01);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;
        //tree 1 talks

        while (time < transitionTimeOpen)
        {
            blendWeightTree01_02 = tree01Renderer.GetBlendShapeWeight(0);
            blendWeightTree01_02 += 100 / transitionTimeOpen * Time.deltaTime;
            tree01Renderer.SetBlendShapeWeight(0, blendWeightTree01_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeClose)
        {
            blendWeightTree01_02 = tree01Renderer.GetBlendShapeWeight(0);
            blendWeightTree01_02 -= 100 / transitionTimeOpen * Time.deltaTime;
            tree01Renderer.SetBlendShapeWeight(0, blendWeightTree02_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeOpen)
        {
            blendWeightTree01_02 = tree01Renderer.GetBlendShapeWeight(0);
            blendWeightTree01_02 += 100 / transitionTimeOpen * Time.deltaTime;
            tree01Renderer.SetBlendShapeWeight(0, blendWeightTree01_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeClose)
        {
            blendWeightTree01_02 = tree01Renderer.GetBlendShapeWeight(0);
            blendWeightTree01_02 -= 100 / transitionTimeOpen * Time.deltaTime;
            tree01Renderer.SetBlendShapeWeight(0, blendWeightTree01_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        yield return new WaitForSeconds(0.5f);

        //tree 2 responds

        while (time < transitionTimeOpen)
        {
            blendWeightTree02_02 = tree01Renderer.GetBlendShapeWeight(0);
            blendWeightTree02_02 += 100 / transitionTimeOpen * Time.deltaTime;
            tree02Renderer.SetBlendShapeWeight(0, blendWeightTree02_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeClose)
        {
            blendWeightTree02_02 = tree02Renderer.GetBlendShapeWeight(0);
            blendWeightTree02_01 -= 100 / transitionTimeOpen * Time.deltaTime;
            tree02Renderer.SetBlendShapeWeight(0, blendWeightTree01_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeOpen)
        {
            blendWeightTree02_02 = tree02Renderer.GetBlendShapeWeight(0);
            blendWeightTree02_02 += 100 / transitionTimeOpen * Time.deltaTime;
            tree02Renderer.SetBlendShapeWeight(0, blendWeightTree02_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        while (time < transitionTimeClose)
        {
            blendWeightTree02_02 = tree02Renderer.GetBlendShapeWeight(0);
            blendWeightTree02_02 -= 100 / transitionTimeOpen * Time.deltaTime;
            tree02Renderer.SetBlendShapeWeight(0, blendWeightTree02_02);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;

        //morph back
        yield return new WaitForSeconds(0.5f);
        while (time < transitionTimeMorph)
        {
            blendWeightTree01_01 = tree01Renderer.GetBlendShapeWeight(1);
            blendWeightTree02_01 = tree02Renderer.GetBlendShapeWeight(1);
            blendWeightTree01_01 -= 50 / transitionTimeMorph * Time.deltaTime;
            blendWeightTree02_01 = blendWeightTree01_01;
            tree01Renderer.SetBlendShapeWeight(1, blendWeightTree01_01);
            tree02Renderer.SetBlendShapeWeight(1, blendWeightTree02_01);
            time += Time.deltaTime;
            yield return null;
        }


        yield return null;
    }
}
