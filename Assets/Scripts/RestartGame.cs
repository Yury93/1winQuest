using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private int index = 0;
    [SerializeField] private GameObject prefabCasino;


    private void Start()
    {
        
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(index);
    }
    public void SelectURL()
    {
        prefabCasino.SetActive(true);
        StartCoroutine(corStart());
    }
    IEnumerator corStart()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
