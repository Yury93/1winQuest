using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalKeeper : MonoBehaviour
{
    [SerializeField] private int score;
    public int Score => score;
    [SerializeField] private int luck;

    [SerializeField] private GameObject sceneWin, sceneLose,buttonNext;

    [Header("SceneEnemy")]
    [SerializeField] private int clickCount;
    [SerializeField] private GameObject sceneEnemy;
    [SerializeField] private Text scoreEnemyTxt;
    [SerializeField] private int enemyScore;
    
    private void Start()
    {
        score = 0;
        enemyScore = 0;
        clickCount = 0;
    }
    private void FixedUpdate()
    {
        luck = UnityEngine. Random.Range(0, 2);
        print(luck);
    }

    public void ScoreUpdate()
    {
        clickCount += 1;
        if (luck == 1)
        {
            enemyScore += 1;
            sceneWin.SetActive(false);
            sceneLose.SetActive(true);
        }
        else
        {
            sceneLose.SetActive(false);
            sceneWin.SetActive(true);
            enemyScore += 0;
        }
        if (clickCount >= 6)
        {
            LoadSceneEnemy();
        }
    }

    public void LoadSceneEnemy()
    {
        sceneWin.SetActive(false);
        sceneLose.SetActive(false);
        sceneEnemy.SetActive(true);
        buttonNext.SetActive(false);
        scoreEnemyTxt.text = "���� ������� ���� �� ������� ���������.";
        StartCoroutine(corGeneralScore());
        IEnumerator corGeneralScore()
        {
            yield return new WaitForSeconds(2f);
            score = UnityEngine.Random.Range(0, 6);
            scoreEnemyTxt.text = $"Score {score}:" + enemyScore.ToString();
            buttonNext.SetActive(true);
        }
    }
}
