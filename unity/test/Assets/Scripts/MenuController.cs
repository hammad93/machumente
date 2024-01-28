using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    public TMP_Text text01;
    public TMP_Text text02;

    // Start is called before the first frame update
    void Awake()
    {
        text01.enabled = false;
        text02.enabled = false;
        StartCoroutine(RunUI());
    }

    IEnumerator RunUI()
    {
        yield return new WaitForSeconds(2f);
        text01.enabled = true;
        yield return new WaitForSeconds(4f);
        text01.enabled = false;
        yield return new WaitForSeconds(2f);
        text02.enabled = true;
        yield return null;
    }
}
