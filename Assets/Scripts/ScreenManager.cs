using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : SingletonBase<ScreenManager>
{
    [SerializeField] private GameObject[] screenGame;
    private int indexScreenGame = 0;

    #region ScreenGame
    /// <summary>
    /// ����� ��������� ��� ������� �� ����� ����� ���� �������, �������� ����������� ������
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
