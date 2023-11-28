using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NewScore")]
public class ScoreDatas : ScriptableObject
{
    public int ScoreValue;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    public void UpdateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 999999);
        UpdateScoreUI();
    }

    public void InitScoreValue(int initValue)
    {
        UpdateScoreValue(initValue);
    }

    public void UpdateScoreUI()
    {
        OnUpdate?.Invoke(ScoreValue);
    }
}
