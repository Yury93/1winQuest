using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// В кнопку сначала подаём саму кнопку на которой этот скрипт, затем подаём ScreenManager
/// </summary>
public class IndexScreen : MonoBehaviour
{
    [Header("index NEXT scene")]
    [SerializeField] private int index = 0;

    public void NewIndexInit(int newIndex)
    {
        index = newIndex;
        print("index "+ index);
    }
   
    public void OnIndex()
    {
        AudioManager.Instance.PLayAudioUI();
        ScreenManager.Instance.SetIndexForScreen(index);
    }
}
