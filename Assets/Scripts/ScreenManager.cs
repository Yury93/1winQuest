using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : SingletonBase<ScreenManager>
{
    [SerializeField] private GameObject[] screenGame;
    private int indexScreenGame = 0;

    #region ScreenGame
    /// <summary>
    /// метод отключает все объекты на сцене кроме того объекта, которому принадлежит индекс
    /// </summary>
    public void NextScreen()
    {
        for (int i = 0; i < screenGame.Length; i++)
        {
            screenGame[i].SetActive(false);
        }
        screenGame[indexScreenGame].SetActive(true);
    }
    public void SetIndexForScreen(int i)
    {
        indexScreenGame = i;
    }
    #endregion

}
