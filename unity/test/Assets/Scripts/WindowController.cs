using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    public GameObject window01;
    public GameObject window02;
    public GameObject window03;
    public GameObject window04;
    private AudioSource audioSource;
    public float conversationTime;

    // Start is called before the first frame update
    void Awake()
    {
        window01.SetActive(false);
        window02.SetActive(false);
        window03.SetActive(false);
        window04.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void StartWindowAction()
    {
        StartCoroutine(WindowAction());
    }

    IEnumerator WindowAction()
    {
        yield return new WaitForSeconds(2);
        window01.SetActive(true);
        window02.SetActive(true);
        window03.SetActive(true);
        window04.SetActive(true);

        audioSource.Play();

        yield return new WaitForSeconds(conversationTime);

        audioSource.Stop();
        window01.SetActive(false);
        window02.SetActive(false);
        window03.SetActive(false);
        window04.SetActive(false);
    }
}
