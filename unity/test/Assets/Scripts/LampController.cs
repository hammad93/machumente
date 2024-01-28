using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public Material lampOff;
    public Material lampOn;
    public List<GameObject> lamps;
    [SerializeField] private List<MeshRenderer> lampRenderers;
    [SerializeField] private List<AudioSource> lampAudioSources;
    //public float startDelay;
    
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < lamps.Count; i++)
        {
            lampRenderers.Add(lamps[i].GetComponent<MeshRenderer>());
            lampAudioSources.Add(lamps[i].GetComponent<AudioSource>());
            lampRenderers[i].material = lampOff;
        }


    }

    public void StartLampAnimation()
    {
        StartCoroutine(LampSwitchOn());
    }

    public IEnumerator LampSwitchOn()
    {
        for(int j = 0; j < lamps.Count; j++)
        {
            lampAudioSources[j].Play();
            StartCoroutine(LampFlicker(j));
            yield return new WaitForSeconds(2);
            

            
        }
        //yield return new WaitForSeconds(startDelay);

        //lamp flickers on a plays a sound
        
        


        
    }

    public IEnumerator LampFlicker(int index)
    {
        yield return new WaitForSeconds(0.5f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.2f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.5f);
        lampRenderers[index].material = lampOn;
        yield return new WaitForSeconds(0.05f);
        lampRenderers[index].material = lampOff;
        yield return new WaitForSeconds(0.3f);
        lampRenderers[index].material = lampOn;
    }
}
