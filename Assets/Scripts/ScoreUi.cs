using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUi : MonoBehaviour
{
    public TMP_Text _scoreText;

    public void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }

    public void UpdateScore(ScoreControl scoreControl)
    {
        _scoreText.text = $"Score: {scoreControl.Score}";
    }


}
