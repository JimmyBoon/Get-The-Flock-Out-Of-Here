using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] int totalSheep;
    [SerializeField] int score = 0;
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        totalSheep = FindObjectsOfType<SheepController>().Length;
    }

    private void Update()
    {
        scoreText.text = ("Sheeps to Wrangle: " + (totalSheep - score));
    }

    public void AddScore(int value)
    {
        score += value;
        if((totalSheep - score) <= 0)
        {
            FindObjectOfType<SceneControl>().ChangeScene();
        }
    }
}
