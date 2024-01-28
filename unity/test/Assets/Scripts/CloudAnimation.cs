using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class CloudAnimation : MonoBehaviour
{
    public MeshRenderer redTrafficLight;
    public MeshRenderer amberTrafficLight;
    public MeshRenderer greenTrafficLight;
    private Color greenOff = new Color(0,0.36f,0.063f);
    private Color greenOn = new Color(0, 1, 0.17f);
    private Color amberOff = new Color(0.51f, 0.4f, 0);
    private Color amberOn = new Color(1, 0.78f, 0);
    private Color redOff = new Color(0.37f, 0.0078f, 0);
    private Color redOn = new Color(1, 0.20f, 0.043f);

    public SkinnedMeshRenderer cloudRenderer;
    public float transitionTime;
    public float currentBlendWeight;
    public float startAlpha = 0.5f;
    private Color cloudColor;
    [SerializeField] private float colorAlpha;
    public float time = 0f;
    public Vector3 rotateEnd = new Vector3(0, 0, 37);

    // Start is called before the first frame update
    void Awake()
    {
        redTrafficLight.material.color = redOff;
        amberTrafficLight.material.color = amberOff;
        greenTrafficLight.material.color = greenOn;
        cloudRenderer.SetBlendShapeWeight(0, 0);
        cloudColor = cloudRenderer.materials[0].color;
        cloudColor.a = startAlpha;
        cloudRenderer.materials[0].color = cloudColor;
        colorAlpha = cloudColor.a;
        

    }

    public void StartCloudAnimation()
    {
        StartCoroutine(AnimateCloud());
    }

    IEnumerator AnimateCloud()
    {
        //yield return new WaitForSeconds(10f);

        //Traffic light and arrow
        amberTrafficLight.material.color = amberOn;
        greenTrafficLight.material.color = greenOff;
        yield return new WaitForSeconds(2);

        redTrafficLight.material.color = redOn;
        amberTrafficLight.material.color = amberOff;

        yield return new WaitForSeconds(2);

        transform.DORotate(rotateEnd, transitionTime);
        



        while (time < transitionTime)
        {
            currentBlendWeight = cloudRenderer.GetBlendShapeWeight(0);
            currentBlendWeight += 100 / transitionTime * Time.deltaTime;
            cloudColor.a += (1-startAlpha)/transitionTime * Time.deltaTime;
            colorAlpha = cloudColor.a;
            cloudRenderer.SetBlendShapeWeight(0, currentBlendWeight);
            cloudRenderer.materials[0].color = cloudColor;
            time += Time.deltaTime;
            yield return null;
        }
        
    }
}
