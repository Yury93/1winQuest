using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject finalImage;
    private void Start()
    {
        StartCoroutine(corEnable());
    }
    IEnumerator corEnable()
    {
        yield return new WaitForSeconds(2f);
        finalImage.SetActive(true);
    }
}
