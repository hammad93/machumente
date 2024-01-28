using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public Material lampOff;
    public Material lampOn;
    private MeshRenderer lampRenderer;
    private AudioSource lampAudioSource;
    public float startDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        lampRenderer = GetComponent<MeshRenderer>();
        lampAudioSource = GetComponent<AudioSource>();
        lampRenderer.material = lampOff;

        StartCoroutine(LampFlicker());

    }

    private IEnumerator LampFlicker()
    {
        yield return new WaitForSeconds(startDelay);

        //lamp flickers on a plays a sound
        lampAudioSource.Play();
        yield return new WaitForSeconds(0.5f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderer.material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderer.material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderer.material = lampOn;


        yield return null;
    }
}
