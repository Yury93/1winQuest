using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    [SerializeField] private GameObject startObj,choosePositionObj;
    private void Start()
    {
        startObj.SetActive(true);
        print("для первой сцены");
    }
    public void ButtonStartDown()
    {
        startObj.SetActive(false);
        choosePositionObj.SetActive(true);
    }
}
