using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    [SerializeField] private int indexScene;

    public void WalkScenePlay()
    {
        SceneManager.LoadSceneAsync(indexScene + 1);
    }
}
