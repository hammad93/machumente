using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AmmoniteAnimation : MonoBehaviour
{
    public Vector3 startScale = new Vector3(2, 2, 2f);
    public Vector3 endScale = new Vector3(5f, 5f, 5f);
    
    public float endX;
    public float endZ;
    private float time01 = 0f;
    private float time02 = 0f;
    public float moveTime = 5f;
    public float timeStop00 = 0.0f;
    public float timeStop01 = 0.05f;
    public float timeStop02 = 0.4f;
    public float timeStop03 = 0.6f;
    public float timeStop04 = 0.7f;
    public float timeStop05 = 0.8f;
    public float blendStop00 = 0.0f;
    public float blendStop01 = 0.0f;
    public float blendStop02 = 90f;
    public float blendStop03 = 100f;
    public float blendStop04 = 100f;
    public float blendStop05 = 0.0f;
    [SerializeField] private float currentBlendWeight;
    //public Transform targetTransform01;
    //public Transform targetTransform02;
    public SkinnedMeshRenderer ammoniteRenderer;
    //public float blendWeight;
    private AudioSource audiosource;


    
    void Awake()
    {
        audiosource = GetComponent<AudioSource>();
        ammoniteRenderer.SetBlendShapeWeight(0,0);
        
    }

    public void StartAmmoniteAnimation()
    {
        StartCoroutine(AnimateAmmonite());
    }

    IEnumerator AnimateAmmonite()
    {
        yield return new WaitForSeconds(0.5f);
        transform.DOScale(endScale, 2f);
        transform.DOMoveZ(endZ, 2f);
        yield return new WaitForSeconds(2.2f);

        transform.DOMoveX(endX, moveTime);
        audiosource.Play();

        while (time01 < moveTime)
        {
            while (time02 < timeStop01)
            {
                currentBlendWeight = ammoniteRenderer.GetBlendShapeWeight(0);
                currentBlendWeight += (blendStop01 - blendStop00) / (timeStop01 - timeStop00 ) * Time.deltaTime;
                ammoniteRenderer.SetBlendShapeWeight(0, currentBlendWeight);
                time01 += Time.deltaTime;
                time02 += Time.deltaTime;
                yield return null;
            }

            while (time02 < timeStop02)
            {
                currentBlendWeight = ammoniteRenderer.GetBlendShapeWeight(0);
                currentBlendWeight += (blendStop02 - blendStop01) / (timeStop02  - timeStop01 ) * Time.deltaTime;
                ammoniteRenderer.SetBlendShapeWeight(0, currentBlendWeight);
                time01 += Time.deltaTime;
                time02 += Time.deltaTime;
                yield return null;
            }

            while (time02 < timeStop03)
            {
                currentBlendWeight = ammoniteRenderer.GetBlendShapeWeight(0);
                currentBlendWeight += (blendStop03 - blendStop02) / (timeStop03  - timeStop02 ) * Time.deltaTime;
                ammoniteRenderer.SetBlendShapeWeight(0, currentBlendWeight);
                time01 += Time.deltaTime;
                time02 += Time.deltaTime;
                yield return null;
            }
            while (time02 < timeStop04)
            {
                currentBlendWeight = ammoniteRenderer.GetBlendShapeWeight(0);
                currentBlendWeight += (blendStop04 - blendStop03) / (timeStop04 - timeStop03 ) * Time.deltaTime;
                ammoniteRenderer.SetBlendShapeWeight(0, currentBlendWeight);
                time01 += Time.deltaTime;
                time02 += Time.deltaTime;
                yield return null;
            }

            while (time02 < timeStop05)
            {
                currentBlendWeight = ammoniteRenderer.GetBlendShapeWeight(0);
                currentBlendWeight += (blendStop05 - blendStop04) / (timeStop05 - timeStop04) * Time.deltaTime;
                ammoniteRenderer.SetBlendShapeWeight(0, currentBlendWeight);
                time01 += Time.deltaTime;
                time02 += Time.deltaTime;
                yield return null;
            }
            time02 = 0;
            yield return null;
        }
        audiosource.Stop();
        
    }
}
