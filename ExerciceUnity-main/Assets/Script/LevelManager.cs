using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;

    private void Start()
    {
        _scoreData.InitScoreValue(0);
    }
}